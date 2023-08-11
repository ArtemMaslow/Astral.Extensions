// See https://aka.ms/new-console-template for more information
using Astral.Extensions.Console.Models;
using Astral.Extensions.SqlHelper;

var sqlHelper = new SqlHelper();
var sql = sqlHelper.GetSqlSelect<User>();
Console.WriteLine(sql);
Console.ReadLine();