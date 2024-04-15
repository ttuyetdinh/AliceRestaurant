using AutoMapper;

namespace AliceRestaurant.MapperConfig
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.ApplyDishMapping();
                config.ApplyRestaurantMapping();
                config.ApplyDropdownMapping();
                config.ApplyDineInCategoryMapping();
                config.ApplyDeliveryCategoryMapping();
                config.ApplyDishHistoryMapping();

            });

            return mappingConfig;
        }
    }
}