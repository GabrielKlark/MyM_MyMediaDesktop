using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUI
{
    class cl_Media
    {
        //A tributos e propriedades do projeto

        //Criação dos Campos
        private int cod_M;
        private string title_M;
        private string date_M;
        private int season_M;
        private string synopsis_M;

        public int Cod_M { get => cod_M; set => cod_M = value; }
        public string Title_M { get => title_M; set => title_M = value; }
        public string Date_M { get => date_M; set => date_M = value; }
        public int Season_M { get => season_M; set => season_M = value; }
        public string Synopsis_M { get => synopsis_M; set => synopsis_M = value; }
    }
}
