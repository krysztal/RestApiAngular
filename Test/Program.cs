using System;
using RAaA.DAL.Entities;
using RAaA.API.DTO;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ProcessorDTO proc = new ProcessorDTO()
            {
                Model = "I7",
                Price = 100
            };

            RAMDTO ram1 = new RAMDTO()
            {
                Model = "Kinston",
                Price = 100
            };

            RAMDTO ram2 = new RAMDTO()
            {
                Model = "GSkill",
                Price = 120
            };

            PCBuildDTO buildDto = new PCBuildDTO()
            {
                Name = "Test",
                TotalPrice = 1000,
                Processor = proc,
                RAMs = new List<RAMDTO>() { ram1, ram2 }
            };

            Mapper.Initialize(cfg => cfg.CreateMap<PCBuildDTO, PCBuild>().ConstructProjectionUsing(p=>p.RAMs.Select(s => new RAM { Model = s.Model, Price = s.Price,  })

            PCBuild build = Mapper.Map<PCBuildDTO, PCBuild>(buildDto);




            Console.ReadKey();
        }
    }
}
