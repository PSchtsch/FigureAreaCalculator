/*
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, 
в одной категории может быть много продуктов.

SQL запрос для выбора всех пар "Имя продукта - Имя категории". Если у продукта нет категорий, то его имя всё-равно выводится:
*/

select products.name, categories.name from products left join categories on products.id = categories.product_id;