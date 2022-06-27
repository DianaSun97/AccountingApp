create table category
(
    category_id int identity
        constraint PK_category
            primary key,
    name        text not null
)
go

INSERT INTO accountant.dbo.category (category_id, name) VALUES (1, N'Food');
INSERT INTO accountant.dbo.category (category_id, name) VALUES (2, N'Transport');
