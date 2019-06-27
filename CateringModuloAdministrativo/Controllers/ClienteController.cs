﻿using Dominio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CateringModuloAdministrativo.Controllers
{
    public class ClienteController : Controller
    {
        /*
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listarCliente()
        {
            List<Cliente> lstCliente = new List<Cliente>();
            lstCliente = objClienteManager.lista_Cliente();
            return View(lstCliente);

        }

        // GET: Cliente/Details/5
        public ActionResult Details(int idCliente)
        {
            Cliente objCliente = new Cliente();
            objCliente = objClienteManager.lista_x_id_Cliente(idCliente);
            return View(objCliente);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            List<TipoCliente> lstTipoCliente = objTipoClienteManager.lista_TipoCliente();
            ViewBag.ListaTipoCliente = new SelectList(objTipoClienteManager.lista_TipoCliente(), "tu_int_idtipousu", "tu_vchar_descr");

            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente objCliente)
        {
            if (!ModelState.IsValid)
            {
                return View(objCliente);
            }
            else
            {
                int respuesta = objClienteManager.insertar_or_actualizar_Cliente(objCliente, "I");
            }

            return RedirectToAction("listarCliente");
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int idCliente)
        {
            Cliente objCliente = new Cliente();
            objCliente = objClienteManager.lista_x_id_Cliente(idCliente);
            return View(objCliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(Cliente objCliente)
        {
            if (!ModelState.IsValid)
            {
                return View(objCliente);
            }
            else
            {
                int respuesta = objClienteManager.insertar_or_actualizar_Cliente(objCliente, "U");
            }

            return RedirectToAction("listarCliente");
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }*/
    }
}