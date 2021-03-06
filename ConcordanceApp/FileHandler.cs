﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using concordanceapConcordationDataSetTableAdaptersp;
using System.Windows.Forms;

namespace concordanceapConcordationDataSetTableAdaptersp
{
    class FileHandler
    {
        //remove special characters from string
        /*public static string RemoveSpecialCharacters(string input)
        {
            Regex r = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return r.Replace(input, String.Empty);
        }*/

        public static string RemoveSpecialCharacters(string str)
        {
            char[] buffer = new char[str.Length];
            int idx = 0;

            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z')
                    || (c >= 'a' && c <= 'z')|| (c == ' '))
                {
                    buffer[idx] = c;
                    idx++;
                }
            }

            return new string(buffer, 0, idx);
        }

        public static void ParseFile(string fileName,int DocID)
        {
            String line;
            ArrayList wordsList = new ArrayList();
            DBConDataContext DB = new DBConDataContext();
            int lineNum = 0;
            int wordNum = 0;
            using (StreamReader reader = new StreamReader(fileName))
            {
                /*while not end of file */
                while ((line = reader.ReadLine()) != null) 
                {
                    /* start of a new line */
                    lineNum++;
                    wordNum = 0;
                    //line = reader.ReadLine();
                    line = RemoveSpecialCharacters(line);
                    if (line == "") continue;
                    line = Regex.Replace(line, @"\s+", " ");
                    line = line.Trim();
                    String[] words = line.Split(' ');
                    /* go through the words in line */
                    foreach (String word in words)
                    {
                        if (word != "")
                        {
                            wordNum++;

                            //string cleanWord = RemoveSpecialCharacters(word);
                            DB.InsertWord2(word, lineNum, wordNum, DocID);
                            /*WordItem item = new WordItem(cleanWord,wordNum,lineNum);
                            wordsList.Add(item);*/
                        }
                    }
                }
                /* Finished reading the file
                 * return the arraylist */
                //return wordsList;
            }
        }
    }
}