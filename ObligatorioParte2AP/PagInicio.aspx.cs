﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;
using DominioParte2ObAP;

namespace ObligatorioParte2AP
{
    public partial class PagInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            Usuario unUsuario = Empresa.Instancia.BuscarUsuario(TxtUsuario.Text, TxtContrasena.Text, RBtnCliente.Text);
            if (unUsuario != null && RBtnCliente.Checked==true)
            {
                Session["Usuario"] = unUsuario;
                Response.Redirect("InicioCliente.aspx");
            }
            else if(unUsuario != null && RBtnOperador.Checked == true)
            {
                Session["Usuario"] = unUsuario;
                Response.Redirect("InicioOperador.aspx");
            }
            else if(TxtUsuario.Text=="" || TxtContrasena.Text=="")
            {
                LblMensaje.Text = "Faltan ingresar datos";
            }
            else
            {
                LblMensaje.Text = "Nombre de usuario o clave incorrecta";
            }
        }

        protected void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("PagRegistroCliente.aspx");
        }
    }
}