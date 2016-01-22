using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppWithEfuowGrsam.Models
{
    public enum TableStatus
    {
        None = 0,
        Added = 1,
        Removed = 2
    }

    public class TableModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TableStatus Status { get; set; }
    }
}