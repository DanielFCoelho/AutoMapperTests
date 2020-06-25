using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocAutoMapperObjectToList
{
    public class MapperConfigurationAccessor
    {
        public static MapperConfiguration Configuration => new MapperConfiguration(config =>
        {
            config.CreateMap<SceneAccessResponse, List<SceneAccess>>()
            .ConvertUsing((source, destination) =>
            {
                destination = new List<SceneAccess>();
                foreach (string users in source.ReleasedUsers)
                {
                    destination.Add(new SceneAccess() { ProgramId = source.ProgramId, SceneId = source.Id });
                }

                return destination;
            });
        });
    }
}
