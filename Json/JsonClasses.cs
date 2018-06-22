using System.Collections.Generic;

/* Code generated using json2csharp licensed with Microsoft Reciprocal License (Ms-RL)
    Ms-RL Conditions and Limitations
    For any file you distribute that contains code from the software (in source code or binary format)
    you must provide recipients the source code to that file along with a copy of this license, which license will govern that file. 
    You may license other files that are entirely your own work and do not contain code from the software under any terms you choose.

As such this file is provided as is and a copy of this license is below:

Microsoft Reciprocal License (Ms-RL)

This license governs use of the accompanying software. 
If you use the software, you accept this license. 
If you do not accept the license, do not use the software.

1. Definitions

The terms "reproduce," "reproduction," "derivative works," and "distribution" have the same meaning here as under U.S. copyright law.

A "contribution" is the original software, or any additions or changes to the software.

A "contributor" is any person that distributes its contribution under this license.

"Licensed patents" are a contributor's patent claims that read directly on its contribution.

2. Grant of Rights

(A) Copyright Grant- Subject to the terms of this license, including the license conditions and limitations in section 3
, each contributor grants you a non-exclusive, worldwide, royalty-free copyright license to reproduce its contribution
, prepare derivative works of its contribution, and distribute its contribution or any derivative works that you create.

(B) Patent Grant- Subject to the terms of this license, including the license conditions and limitations in section 3
, each contributor grants you a non-exclusive, worldwide
, royalty-free license under its licensed patents to make, have made, use, sell, offer for sale, import
, and/or otherwise dispose of its contribution in the software or derivative works of the contribution in the software.

3. Conditions and Limitations

(A) Reciprocal Grants- For any file you distribute that contains code from the software (in source code or binary format)
, you must provide recipients the source code to that file along with a copy of this license, which license will govern that file. 
You may license other files that are entirely your own work and do not contain code from the software under any terms you choose.

(B) No Trademark License- This license does not grant you rights to use any contributors' name, logo, or trademarks.

(C) If you bring a patent claim against any contributor over patents that you claim are infringed by the software, 
your patent license from such contributor to the software ends automatically.

(D) If you distribute any portion of the software, you must retain all copyright, patent, trademark, 
and attribution notices that are present in the software.

(E) If you distribute any portion of the software in source code form, you may do so only under this license 
by including a complete copy of this license with your distribution. 
If you distribute any portion of the software in compiled or object code form, 
you may only do so under a license that complies with this license.

(F) The software is licensed "as-is." You bear the risk of using it. 
The contributors give no express warranties, guarantees or conditions. 
You may have additional consumer rights under your local laws which this license cannot change. 
To the extent permitted under your local laws, the contributors exclude the implied warranties of merchantability, 
fitness for a particular purpose and non-infringement.
*/
namespace JapaneseApp
{
    public class Meta
    {
        public int status { get; set; }
    }

    public class Japanese
    {
        public string word { get; set; }
        public string reading { get; set; }
    }

    #region Senses

    public class Sense
    {
        public List<string> english_definitions { get; set; }
        public List<string> parts_of_speech { get; set; }
        public List<Link> links { get; set; }
        public List<string> tags { get; set; }

        //As of 6/21/18
        //these are all emptpy -> the jisho.org API has not implemented these fully
        public List<object> restrictions { get; set; }
        public List<object> see_also { get; set; }//see_also rarely has a result
        public List<object> antonyms { get; set; }
        public List<object> source { get; set; }
        public List<object> info { get; set; }
        public List<object> sentences { get; set; }
    }

    public class Link
    {
        public string text { get; set; }
        public string url { get; set; }
    }

    #endregion

    public class Attribution
    {
        public bool jmdict { get; set; }
        public bool jmnedict { get; set; }
        public string dbpedia { get; set; }
    }

    public class Datum
    {
        public bool is_common { get; set; }
        public List<string> tags { get; set; }
        public List<Japanese> japanese { get; set; }
        public List<Sense> senses { get; set; }
        public Attribution attribution { get; set; }
    }

    public class RootObject
    {
        public Meta meta { get; set; }
        public List<Datum> data { get; set; }
    }
}
