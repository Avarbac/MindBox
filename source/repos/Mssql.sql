SELECT Products.title, Categories.title from Products
LEFT JOIN ProductsCategories
ON ProductsCategories.productId = Products.id
LEFT JOIN Categories
ON ProductsCategories.caregoryId = Categories.id