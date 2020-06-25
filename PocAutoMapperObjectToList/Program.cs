using AutoMapper;
using System;
using System.Collections.Generic;

namespace PocAutoMapperObjectToList
{
    class Program
    {
        static void Main(string[] args)
        {
            IMapper _mapper = new Mapper(MapperConfigurationAccessor.Configuration);

            var response = new SceneAccessResponse
            {
                ProgramId = 28862,
                Id = 124524,
                ReleasedUsers = new List<string>
                {
                    "1","2","3"
                }
            };

            List<SceneAccess> scenesAccess = _mapper.Map<List<SceneAccess>>(response);

            Console.WriteLine(scenesAccess.Count);
        }
    }
}
