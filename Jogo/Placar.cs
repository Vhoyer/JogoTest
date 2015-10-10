using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    /// <summary>
    /// Gerencia o placar
    /// </summary>
    class Placar
    {
        public DataTable table;
        DataRow row;

        public Placar(string[] ar)
        {
            table = new DataTable();
            DataColumn collumn = new DataColumn("Nome", typeof(string));
            table.Columns.Add(collumn);
            collumn = new DataColumn("Valor", typeof(int));
            table.Columns.Add(collumn);
            for (int i = 0; i < ar.Length; i++)
            {
                row = table.NewRow();
                row["Nome"] = ar[i];
                row["Valor"] = 0;
                table.Rows.Add(row);
            }
        }
    }
}
