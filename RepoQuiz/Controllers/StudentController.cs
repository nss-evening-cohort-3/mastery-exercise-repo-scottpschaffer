﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoQuiz.DAL;
using RepoQuiz.Models;

namespace RepoQuiz.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentRepository sr = new StudentRepository();
            List<Student> studentList = sr.GetStudentsFromDB();
            ViewBag.ListOfStudents = studentList;
            return View();
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
