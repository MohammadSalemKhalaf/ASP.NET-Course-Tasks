--1
select product_name,model_year,list_price from	production.products
where model_year in (2016,2017,2018);


--2
select p.product_name,p.model_year,p.list_price ,c.category_name from	production.products p
join production.categories c
on p.category_id=c.category_id
where model_year in (2016,2017,2018);

--3
select p.product_name,p.model_year,p.list_price ,c.category_name ,b.brand_name  from	production.products p
join production.categories c
on p.category_id=c.category_id
join production.brands b
on p.brand_id=b.brand_id
where model_year in (2016,2017,2018);
