﻿using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
    internal class FindBookByTitleDataDelegate : DataReaderDelegate<IReadOnlyList<Title>>
    {
        string TitleName { get; }

        public FindBookByTitleDataDelegate(string titleName) : base("Libraries.FindBookByTitle")
        {
            TitleName = titleName;
        }

        public override IReadOnlyList<Title> Translate(SqlCommand command, SqlDataReader reader)
        {
            var books = new List<Title>();

            while (reader.Read())
            {
                books.Add(new Title(
                    reader.GetInt(reader.GetOriginal("TitleID")),
                    reader.GetString(reader.GetOriginal("ISBN")),
                    reader.GetInt(reader.GetOriginal("AuthorID")),
                    "%" + TitleName + "%",
                    reader.GetInt(reader.GetOriginal("PublicationYear"))));
            }
            return books;
        }
    }
}

//It doesn't acknowledge Title (from Title.cs) and it doesn't acknowledge SqlCommand/Reader 
//Also doesn't acknowledge DataReaderDelegate