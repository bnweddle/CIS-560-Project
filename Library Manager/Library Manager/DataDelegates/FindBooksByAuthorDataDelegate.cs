﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;


namespace Library_Manager.DataDelegates
{
    class FindBooksByAuthorDataDelegate : DataReaderDelegate<List<Title>>
    {
        int authorID;
        public FindBooksByAuthorDataDelegate(int aid)
            : base("Libraries.FindBooksByAuthor")
        {
            authorID = aid;
        }

        public override List<Title> Translate(SqlCommand command, SqlDataReader reader)
        {
            List<Title> list = new List<Title>();

            while (reader.Read())
            {
                list.Add(new Title(reader.GetInt32(reader.GetOrdinal("TitleID")),
                                    reader.GetInt32(reader.GetOrdinal("AuthorID")),
                                    reader.GetString(reader.GetOrdinal("ISBN")),
                                    reader.GetString(reader.GetOrdinal("Name")),
                                    reader.GetInt32(reader.GetOrdinal("PublicationYear"))));
            }
            return list;
        }

    }
}