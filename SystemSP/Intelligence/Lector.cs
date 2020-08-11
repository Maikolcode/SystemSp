﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using SystemSP.Data;
using SystemSP.Entitys;
using DTOSystemSp.EntitysInicioApp;
using System.Net;

namespace SystemSP.Intelligence
{
    public class Lector
    {
        public ECardProjectPopular OtenerTajetas()
        {
            var tarjetas = new ECardProjectPopular();
            try
            {
                string jsonResult = _jsonFile(@"Data\cardPopulares.json");
                tarjetas = (ECardProjectPopular)JsonConvert.DeserializeObject(
                    jsonResult, typeof(ECardProjectPopular));
            }
            catch (Exception ex){}
            return tarjetas;
        }
        public ProyectosDestacados ObtenerProyectos() 
        {
            var proyecto = new ProyectosDestacados();
            try
            {
                string jsonResult = _jsonFile(@"Data\carproyectos.json");
                proyecto = (ProyectosDestacados)JsonConvert.DeserializeObject(
                    jsonResult, typeof(ProyectosDestacados));
            }
            catch (Exception ex) { }
            return proyecto;
        }
        public InformacionProyecto ObtenerCategorias() 
        {
            var categoria = new InformacionProyecto();
            try
            {
                string jsonResult = _jsonFile(@"Data\card_categorias.json");
                categoria = (InformacionProyecto)JsonConvert.DeserializeObject(
                    jsonResult, typeof(InformacionProyecto));
            }
            catch (Exception ex) { }
            return categoria;
        }
        public ListaCategoriaVista ObtenerListaCategorias() 
        {
            var categorias = new ListaCategoriaVista();
            try
            {
                string jsonResult = _jsonFile(@"Data\vistaCategorias.json");
                categorias = (ListaCategoriaVista)JsonConvert.DeserializeObject(
                    jsonResult, typeof(ListaCategoriaVista));
            }
            catch (Exception ex) { }
            return categorias;
        }
        private string _jsonFile(string archivoNombre) 
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), archivoNombre);
            return File.ReadAllText(path);
        }
    }
}
