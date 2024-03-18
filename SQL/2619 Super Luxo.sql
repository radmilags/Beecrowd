SELECT products.name, providers.name, CAST(products.price AS DECIMAL(10, 2))
FROM providers
INNER JOIN products ON providers.id = products.id_providers
INNER JOIN categories ON products.id_categories = categories.id
WHERE products.price > 1000 AND categories.name = 'Super Luxury';
