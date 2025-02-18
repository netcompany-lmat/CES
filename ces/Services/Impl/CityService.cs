﻿using ces.Models;
using ces.Repositories;

namespace ces.Services.Impl
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<List<City>> GetCities()
        {
            return await _cityRepository.GetCities();
        }

        public City GetCity(string city)
        {
            return _cityRepository.GetCities().Result.SingleOrDefault(q => q.Name == city);
        }
    }
}
