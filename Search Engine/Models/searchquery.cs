using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Search_Engine.Models
{
    public class searchquery
    {
        
        public string query { get; set; } //variable to hold user query which entered in search space , this variable has been filled in searchquery() in search controller



        //Function to apply tokenization and case folding , split query into words and store those words in 'searchquery_terms'

        public string[] Query_to_words()
        {
            char[] split_token = { ' ', ',', '!', '@', '#', '&', '“', '”', '‘', '—', '(', ')', '–', '[', '{', '}', ']', ':', ';', '?', '/', '*', '.', '-', '"', '\'', '\\', '%', '$', '^', '\r', '\n', '~', '`', '’', ',', '?', '_' };
            string searchquery = query.ToLower();
            string[] searchquery_terms = searchquery.Split(split_token);
            return searchquery_terms;
        }
    }
}