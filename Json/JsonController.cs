using KanaConverterLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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

        #region Japanese

        public int numOfJapaneses()
        {
            if (json == null)
                throw new NullReferenceException();
            return json.data[currentResult].japanese.Count;
        }

        private List<string> getMultiple(int maxIndex, Func<int, string> JsonGetStringAtIndex)
        {
            if (json == null || maxIndex < 0 || JsonGetStringAtIndex == null)
                throw new ArgumentException();

            List<string> list = new List<string>();
            for (int i = 0; i < maxIndex; i++)
                list.Add(JsonGetStringAtIndex(i));
            return list;
        }

        #region Japanese Words

        public string getWord(int japaneseIndex)
        {
            if (japaneseIndex < numOfJapaneses())
            {
                return json.data[currentResult].japanese[japaneseIndex].word;
            }
            else
            {
                throw new IndexOutOfRangeException();//japaneseIndex >= numOfJapanese
            }
        }

        public List<string> getWords()
        {
            return getMultiple(numOfJapaneses(), getWord);
        }

        #endregion

        #region Japanese Readings

        public string getReading(int japaneseIndex)
        {
            if (japaneseIndex < numOfJapaneses())
            {
                return json.data[currentResult].japanese[japaneseIndex].reading;
            }
            else
            {
                throw new IndexOutOfRangeException();//japaneseIndex >= numOfJapaneses
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

        public Japanese getJapanese(int japaneseIndex)
        {
           return getJapaneses()[japaneseIndex];
        }
        public List<Japanese> getJapaneses()
        {
           return json.data[currentResult].japanese;
        }

        #endregion

        #endregion

        #region Senses

        public int numOfSenses()
        {
            return json.data[currentResult].senses.Count;
        }

        private List<string> getMultipleStringSenses(Func<int, int> numOfThisSense, Func<int, int, string> JsonGetStringAtIndices)
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
        private List<object> getMultipleObjectSenses(Func<int, int> numOfThisSense, Func<int, int, object> JsonGetStringAtIndices)
        {
            if (json == null || numOfThisSense == null || JsonGetStringAtIndices == null)
                throw new ArgumentException();

            List<object> list = new List<object>();

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
            return json.data[currentResult].senses[senseIndex].english_definitions.Count;
        }

        public string getEnglishDefiniton(int senseIndex, int englishDefinitionsIndex)
        {
            return json.data[currentResult].senses[senseIndex].english_definitions[englishDefinitionsIndex];
        }

        public List<string> getEnglishDefinitions()
        {
            return getMultipleStringSenses(numOfDefinitions, getEnglishDefiniton);
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
            return getMultipleStringSenses(numOfPartsOfSpeech, getPartOfSpeech);
        }

        #endregion

        #region links

        public int numOfLinks(int senseIndex)
        {
            return json.data[currentResult].senses[senseIndex].links.Count;
        }

        public object getLink(int senseIndex, int linkIndex)
        {
            return json.data[currentResult].senses[senseIndex].links[linkIndex];
        }

        public List<object> getLinks()
        {
            return getMultipleObjectSenses(numOfLinks, getLink);
        }

        public string getLinkText(int senseIndex, int linkIndex)
        {
            return json.data[currentResult].senses[senseIndex].links[linkIndex].text;
        }
        public string getLinkUrl(int senseIndex, int linkIndex)
        {
            return json.data[currentResult].senses[senseIndex].links[linkIndex].url;
        }
        #endregion

        #region tags


        public int numOfTags(int senseIndex)
        {
            return json.data[currentResult].senses[senseIndex].tags.Count;
        }

        public string getTag(int senseIndex, int tagIndex)
        {
            return json.data[currentResult].senses[senseIndex].tags[tagIndex];
        }

        public List<string> getTags()
        {
            return getMultipleStringSenses(numOfTags, getTag);
        }




        #endregion

        #endregion

        public bool isCommon(int index)
        {
            return json.data[index].is_common;
        }

        public Attribution getAttribution(int index)
        {
            return json.data[index].attribution;
        }




        public List<string[]> getRows()
        {
            List<string[]> rows = new List<string[]>();


            List<string> words = getWords();
            List<string> readings = getReadings();
            List<string> romajis = getRomajis();
            List<string> partsOfSpeech = getPartsOfSpeech();

            //reading ought to be the most out of these 4
            int max = readings.Count;

            List<Link> links = getLinks().Cast<Link>().ToList();
            List<string> tags = getTags();



            //make all the rows
            for (int i = 0; i < readings.Count; i++)
            {
                string[] row = new string[8];
                rows.Add(row);
            }


            //add kanji, readings, romaji, PartsOfSpeech
            for (int i = 0; i < readings.Count; i++)
            {
                rows[i][0] = i >= words.Count ? "" : words[i];
                rows[i][1] = readings[i];
                rows[i][2] = romajis[i];
                rows[i][3] = i >= partsOfSpeech.Count ? "" : partsOfSpeech[i];
                rows[i][4] = i >= links.Count ? "" : "text: " + links[i].text + "\nurl: " + links[i].url;
                rows[i][5] = i >= tags.Count ? "" : tags[i];
                rows[i][6] = isCommon(i).ToString();

                Attribution currAttribution = getAttribution(i);
                rows[i][7] = "jmdict: " + currAttribution.jmdict.ToString() + "\njmnedict: " + currAttribution.jmnedict.ToString() + "\ndbpedia: "  + currAttribution.dbpedia;
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