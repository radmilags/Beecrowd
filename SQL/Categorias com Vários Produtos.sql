select products.name, categories.name 
from products inner join categories on id_categories = categories.id
where (id_categories = 1 or id_categories = 2 or id_categories = 3 or id_categories = 6 or id_categories = 9) and (products.amount > 100)
order by id_categories asc
