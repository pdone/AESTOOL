using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AESTOOL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string text = string.Empty, result = string.Empty;

        private void encrypt_Click(object sender, EventArgs e)
        {
            outputText.Clear();
            Encrypt(1);
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            inputText.Clear();
            Decrypt(1);
        }

        private void encryptBase64_Click(object sender, EventArgs e)
        {
            outputText.Clear();
            Encrypt(0);
        }

        private void decryptBase64_Click(object sender, EventArgs e)
        {
            inputText.Clear();
            Decrypt(0);
        }

        private void Encrypt(int resultType)
        {
            try
            {
                string key = aesKey.Text.Trim();
                text = inputText.Text.Trim();
                result =new AES(key).Encrypt(text, resultType);
                outputText.AppendText(result);
            }
            catch (Exception ex)
            {
                outputText.AppendText(ex.Message);
            }
        }

        private void Decrypt(int resultType)
        {
            try
            {
                string key = aesKey.Text.Trim();
                text = outputText.Text.Trim();
                result =new AES(key).Decrypt(text, resultType);
                inputText.AppendText(result);
            }
            catch (Exception ex)
            {
                inputText.AppendText(ex.Message);
            }
        }
        private void formatJson_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = inputText.Text.Trim();
                inputText.Clear();
                inputText.AppendText(ConvertJsonString(temp));
                temp = "";
            }
            catch (Exception ex)
            {
                inputText.Clear();
                inputText.AppendText(ex.Message);
            }
        }

        #region 格式化json 
        /// <summary>
        /// JSON字符串格式化
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static string JsonTree(string json)
        {
            int level = 0;
            var jsonArr = json.ToArray();  // Using System.Linq;
            string jsonTree = string.Empty;
            for (int i = 0; i < json.Length; i++)
            {
                char c = jsonArr[i];
                if (level > 0 && '\n' == jsonTree.ToArray()[jsonTree.Length - 1])
                {
                    jsonTree += TreeLevel(level);
                }
                switch (c)
                {
                    case '[':
                        jsonTree += c + "\n";
                        level++;
                        break;
                    case ',':
                        jsonTree += c + "\n";
                        break;
                    case ']':
                        jsonTree += "\n";
                        level--;
                        jsonTree += TreeLevel(level);
                        jsonTree += c;
                        break;
                    default:
                        jsonTree += c;
                        break;
                }
            }
            return jsonTree;
        }
        /// <summary>
        /// 树等级
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        private static string TreeLevel(int level)
        {
            string leaf = string.Empty;
            for (int t = 0; t < level; t++)
            {
                leaf += "\t";
            }
            return leaf;
        }
        #endregion
        private void encryptSHA256_Click(object sender, EventArgs e)
        {
            try
            {
                outputText.Clear();
                text = inputText.Text.Trim();
                result = GetSHA256(text).ToUpper();
                outputText.AppendText(result);
            }
            catch (Exception ex)
            {
                outputText.Clear();
                outputText.AppendText(ex.Message);
            }
        }

        private string ConvertJsonString(string str)
        {
            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }
        }
        public string GetSHA256(string strData)
        {
            byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(strData);
            try
            {
                SHA256 sha256 = new SHA256CryptoServiceProvider();
                byte[] retVal = sha256.ComputeHash(bytValue);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("To SHA256 fail,error:" + ex.Message);
            }
        }
    }
}
