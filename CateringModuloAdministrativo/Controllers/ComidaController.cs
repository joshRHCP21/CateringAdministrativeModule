﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Dominio.Core.Entities;
using Dominio.Core.MainModule;


namespace CateringModuloAdministrativo.Controllers
{
    public class ComidaController : Controller
    {

        private Alimento_Manager objAlimentoManager = new Alimento_Manager();
      
        // GET: Alimento
        public ActionResult Index()
        {
            return View();
        }

        // GET: Alimento/Details/5
        public ActionResult ListarAlimento()
        {
            List<Alimento> lstAlimento = new List<Alimento>();

            try
            {
                lstAlimento = objAlimentoManager.lista_Alimento();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception source", e.Source);
                lstAlimento = new List<Alimento>();
            }
            return View(lstAlimento);
        }

        // GET: Alimento/Create
        public ActionResult AgregarAlimento()
        {
            return View(new Alimento());
        }

        // POST: Alimento/Create
        [HttpPost]
        public ActionResult AgregarAlimento(Alimento objAlimento)

        {
            if (!ModelState.IsValid)
            {
                return View(objAlimento);
            }
            else
            {
                int respuesta = objAlimentoManager.registrar_Alimento(objAlimento);
                if (respuesta == 1)
                {
                    ViewBag.mensaje = "ALIMENTO GUARDADO";
                }
            }
            return RedirectToAction("ListarAlimento");
        }


        public ActionResult verAlimento(int idAlimento)
        {

            Alimento objAlimento = new Alimento();
            objAlimento = objAlimentoManager.ver_Alimento(idAlimento);
            return View(objAlimento);


        }



        // GET: Alimento/Edit/5
        public ActionResult Edit(int idAlimento)
        {
            Alimento objAlimento = new Alimento();
            objAlimento = objAlimentoManager.ver_Alimento(idAlimento);
            return View(objAlimento);
        }

        // POST: Alimento/Edit/5
        [HttpPost]
        public ActionResult EditarAlimento(Alimento objAlimento)
        {
            if (!ModelState.IsValid)
            {
                return View(objAlimento);
               }
            else
            {
                int respuesta = objAlimentoManager.actualizar_Alimento(objAlimento);
                if (respuesta == 1)
                {
                    ViewBag.mensaje = "ALIMENTO ACTUALIZADO";
                }
            }
            return RedirectToAction("ListarAlimento");
        }






    }
}