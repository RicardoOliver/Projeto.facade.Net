﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Facade_Modelos.Web.ViewModel
{
    interface IViewModel<Tipo>
    {
        void PreencherDadosView(Tipo dados);
        Tipo CriarModelo();
    }
}
