using KanaConverterLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace JapaneseApp
{
    class JsonController
    {
        WebClient webClient;
        private int currentResult;

        RootObject json;
        KanaRomajiConverter kanaRomajiConverter;

        public JsonController()
        {
            json = null; 

            webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;

            kanaRomajiConverter = new KanaRomajiConverter();

            currentResult = 0;
        }

        /* Makes list of strings 
         * does so by calling a function that gets a single string at an index
         */
        private List<string> getMultiple(int maxIndex, Func<int, string> JsonGetStringAtIndex)
        {
            if (json == null || maxIndex < 0 || JsonGetStringAtIndex == null)
                throw new ArgumentException();
          
            List<string> list = new List<string>();
            for (int i = 0; i < maxIndex; i++)
                list.Add(JsonGetStringAtIndex(i));
            return list;
        }

        #region Japanese

        public int numOfJapaneses()
        {
            if (json == null)
                throw new NullReferenceException();
            return json.data[currentResult].japanese.Count;
        }

        #region Japanese Words

        public string getWord(int wordIndex)
        {
            if (wordIndex < numOfJapaneses())
            {
                return json.data[currentResult].japanese[wordIndex].word;
            }
            else
            {
                throw new IndexOutOfRangeException();//wordIndex > numOfJapanese
            }
        }

        public List<string> getWords()
        {
            return getMultiple(numOfJapaneses(), getWord);
        }

        #endregion

        #region Japanese Readings

        public string getReading(int readingIndex)
        {
            if (readingIndex < numOfJapaneses())
            {
                return json.data[currentResult].japanese[readingIndex].reading;
            }
            else
            {
                throw new IndexOutOfRangeException();//readingIndex > numOfJapaneses
            }
        }

        public List<string> getReadings()
        {
            return getMultiple(numOfJapaneses(), getReading);
        }

        #endregion

        #region Japanese Romaji

        public string getRomaji(string kana)
        {
            return kanaRomajiConverter.Convert(kana);
        }

        public List<string> getRomajis()
        {
            List<string> readings = getReadings();
            for (int i = 0; i < readings.Count; i++)
                readings[i] = getRomaji(readings[i]);
            return readings;
        }

        #endregion

        #region Japanese (get both word, reading, romaji)

        public string getJapanese(int japaneseIndex)
        {
            if(japaneseIndex >= numOfJapaneses())
                throw new ArgumentException();

            string word = getWord(japaneseIndex);

            string reading = getReading(japaneseIndex);//there should always be a reading
            if (string.IsNullOrWhiteSpace(reading))
                throw new System.IO.InvalidDataException();

            string romaji = getRomaji(reading);

            if (string.IsNullOrWhiteSpace(word))
                word = "";

            return word + "     " + reading + "     " + romaji;
            
        }

        public List<string> getJapaneses()
        {
            return getMultiple(numOfJapaneses(), getJapanese);
        }
        #endregion

        #endregion

        #region Seneses

        public int numOfSenses()
        {
            return json.data[currentResult].senses.Count;
        }

        private List<string> getMultipleSeneses(Func<int, int> numOfThisSense, Func<int, int, string> JsonGetStringAtIndices)
        {
            if (json == null || numOfThisSense == null || JsonGetStringAtIndices == null)
                throw new ArgumentException();

            List<string> list = new List<string>();

            for (int j = 0; j < numOfSenses(); j++)
            {
                for (int i = 0; i < numOfThisSense(j); i++)
                {
                    list.Add(JsonGetStringAtIndices(j, i));
                }
            }
            return list;
        }

        #region English definitions

        public int numOfDefinitions(int senseIndex)
        {
            return json.data[currentResult].senses[senseIndex].parts_of_speech.Count;
        }

        public string getEnglishDefiniton(int sensesIndex, int englishDefinitionsIndex)
        {
            return json.data[currentResult].senses[sensesIndex].english_definitions[englishDefinitionsIndex];
        }

        public List<string> getEnglishDefinitions()
        {
            return getMultipleSeneses(numOfDefinitions, getEnglishDefiniton);
        }

        #endregion

        #region partsOfSpeech

        public int numOfPartsOfSpeech(int senseIndex)
        {
            return json.data[currentResult].senses[senseIndex].parts_of_speech.Count;
        }

        public string getPartOfSpeech(int sensesIndex, int partOfSpeechIndex)
        {
            string result = json.data[currentResult].senses[sensesIndex].parts_of_speech[partOfSpeechIndex];
            if (result.Equals("Wikipedia definition"))//jisho api has some of this nonsense ignore it; Wikipedia definition should not be a part of speech
                return "";
            return result;
        }

        public List<string> getPartsOfSpeech()
        {
            return getMultipleSeneses(numOfPartsOfSpeech, getPartOfSpeech);
        }

        #endregion

        #endregion

        public List<string[]> getRows()
        {
            List<string[]> rows = new List<string[]>();


            List<string> words = getWords();
            List<string> readings = getReadings();
            List<string> romajis = getRomajis();
            List<string> partsOfSpeech = getPartsOfSpeech();


            int max = readings.Count;//reading ought to be the most

            //make all the rows
            for (int i = 0; i < readings.Count; i++)
            {
                string[] row = new string[4];
                rows.Add(row);
            }


            //add kanji, readings, romaji, PartsOfSpeech
            for (int i = 0; i < readings.Count; i++)
            {
                rows[i][0] = i >= words.Count ? "" : words[i];
                rows[i][1] = readings[i];
                rows[i][2] = romajis[i];
                rows[i][3] = i >= partsOfSpeech.Count ? "" : partsOfSpeech[i];
            }
            return rows;
        }

        #region Jisho.org Api

        public int numOfResults()
        {
            return json.data.Count;
        }
        public RootObject setJson(string query)
        {
            query = webClient.DownloadString("https://jisho.org/api/v1/search/words?keyword=\"" + query.ToLower() + "\"");

            //use Newtonsoft.json to convert json from web to RootObject
            json = JsonConvert.DeserializeObject<RootObject>(query);
            if (numOfResults() == 0)
                json = null;
            currentResult = 0;
            return json;
        }

        /*update to next result
         * E.g
         * json.data[currentResult] -> json.data[currentResult+1]
         * if at last result nextResult -> currentResult = 0
         */
        public void nextResult()
        {
            if (currentResult < numOfResults() - 1)
                currentResult++;
            else//at last result nextResult -> reset to 0.
            {
                currentResult = 0;
            }
        }

        #endregion
    }
}