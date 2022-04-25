Use Test

Select FoodName, CategoryName From Food a inner join FoodCategory b on a.FoodId=b.FoodId inner join Category c on c.CategoryId=b.CategoryId order by (FoodName)