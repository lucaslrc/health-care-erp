using System;
using System.IO;
using System.Linq;
using System.Data;
using ExcelDataReader;
using HealthCareERP.Data;
using HealthCareERP.Entities;
using HealthCareERP.Rules;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HealthCareERP.Services
{
    public class InitService : IStorage
    {
        private readonly HealthCareERPContext DbContext;
        public void Init()
        {
            if (VerifyDataBaseServer())
            {
                try
                {
                    if (!VerifyDataBaseExists())
                    {
                        ApplyMigration();
                    }
                }
                catch
                {
                    throw new Exception("The DataBase operation has fail, verify.");
                }
            }
        }

        public void ApplyMigration()
        {
            DbContext.Database.Migrate();
        }

        public Medicine FindMedicine(string Register)
        {
            throw new NotImplementedException();
        }

        public Storage FindStorage(string LoteID)
        {
            throw new NotImplementedException();
        }

        public void MigrateAnvisaSheet()
        {
            var path = Directory.GetFiles(@"./Public/Anvisa/")
                                    .Where(x => x.EndsWith(".xls")).FirstOrDefault();

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);                                  
            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Choose one of either 1 or 2:

                    // 1. Use the reader methods
                    do
                    {
                        while (reader.Read())
                        {
                            // reader.GetDouble(0);
                        }
                    } while (reader.NextResult());

                    // 2. Use the AsDataSet extension method
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        // Gets or sets a value indicating whether to set the DataColumn.DataType 
                        // property in a second pass.
                        UseColumnDataType = true,

                        // Gets or sets a callback to determine whether to include the current sheet
                        // in the DataSet. Called once per sheet before ConfigureDataTable.
                        FilterSheet = (tableReader, sheetIndex) => true,

                        // Gets or sets a callback to obtain configuration options for a DataTable. 
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            // Gets or sets a value indicating the prefix of generated column names.
                            EmptyColumnNamePrefix = "Column",

                            // Gets or sets a value indicating whether to use a row from the 
                            // data as column names.
                            UseHeaderRow = false,

                            // Gets or sets a callback to determine which row is the header row. 
                            // Only called when UseHeaderRow = true.
                            ReadHeaderRow = (rowReader) => {
                                // F.ex skip the first row and use the 2nd row as column headers:
                                rowReader.Read();
                            },

                            // Gets or sets a callback to determine whether to include the 
                            // current row in the DataTable.
                            FilterRow = (rowReader) => {
                                return true;
                            },

                            // Gets or sets a callback to determine whether to include the specific
                            // column in the DataTable. Called once per column after reading the 
                            // headers.
                            FilterColumn = (rowReader, columnIndex) => {
                                return true;
                            }
                        }
                    });

                    // var dataSet = result;

                    // DataTable dt = dataSet.Tables[0];

                    var table = result.Tables[0];
                    Console.WriteLine(table.Columns.Count);

                    for (int i = 0; i < result.Tables[0].Rows.Count; i++)
                    {
                        Console.WriteLine(result.Tables[0].Rows[i][0]);
                    }

                    
                    // The result of each spreadsheet is in result.Tables
                }
            }
        }

        public bool VerifyDataBaseExists()
        {
            Utils.Log.CommitInLog("");
            return DbContext.Storages.Select(x => x.ID) != null ? true : false;
        }

        public bool VerifyDataBaseServer()
        {
            return DbContext.Database.CanConnectAsync().IsCompletedSuccessfully ? true : false;
        }
    }
}