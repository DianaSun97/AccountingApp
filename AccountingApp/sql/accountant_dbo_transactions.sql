create table transactions
(
    transaction_id int identity
        constraint PK_transactions
            primary key,
    date           date  not null,
    price          money not null,
    category_id    int   not null
        constraint FK_transactions_category
            references category,
    comments       text
)
go

INSERT INTO accountant.dbo.transactions (transaction_id, date, price, category_id, comments) VALUES (1, N'2022-06-28', 10.2000, 1, null);
INSERT INTO accountant.dbo.transactions (transaction_id, date, price, category_id, comments) VALUES (2, N'2022-06-15', 21.4000, 2, N'bolt');
INSERT INTO accountant.dbo.transactions (transaction_id, date, price, category_id, comments) VALUES (5, N'2022-06-23', 222.1000, 1, N'wolt');
INSERT INTO accountant.dbo.transactions (transaction_id, date, price, category_id, comments) VALUES (6, N'2022-06-15', 11.0000, 2, N'bolt scooter');
