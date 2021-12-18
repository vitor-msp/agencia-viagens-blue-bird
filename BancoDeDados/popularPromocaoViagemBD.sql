use AgenciaViagens;
go
-- inserção de promoções (o campo destino deve ser preenchido com o id do destino, portanto é 
-- necessário verificar quais id's foram gerados no seu banco de dados
insert into Promocao (destino, desconto, vencimento) values 
(1,0.5,convert(datetime,'2021-12-31 00:00:00',120)),
(null,0.25,convert(datetime,'2022-01-05 00:00:00',120)),
(6,0.15,convert(datetime,'2022-01-01 09:00:00',120));
go
-- inserção de viagens (o campo destino deve ser preenchido com o id do destino, portanto é 
-- necessário verificar quais id's foram gerados no seu banco de dados
insert into Viagem (destino, partida, chegada, vlr_padrao) values 
(1,convert(datetime,'2021-12-29 08:00:00',120),convert(datetime,'2021-12-29 09:00:00',120),250),
(1,convert(datetime,'2021-12-30 09:00:00',120),convert(datetime,'2021-12-30 10:00:00',120),270),
(2,convert(datetime,'2021-12-30 09:30:00',120),convert(datetime,'2021-12-30 10:20:00',120),290),
(2,convert(datetime,'2021-12-31 14:30:00',120),convert(datetime,'2021-12-31 15:20:00',120),290),
(3,convert(datetime,'2022-01-01 09:30:00',120),convert(datetime,'2022-01-01 10:50:00',120),290),
(3,convert(datetime,'2022-01-02 09:00:00',120),convert(datetime,'2022-01-02 10:05:00',120),290),
(4,convert(datetime,'2021-12-30 11:30:00',120),convert(datetime,'2021-12-30 12:45:00',120),290),
(4,convert(datetime,'2021-12-31 12:30:00',120),convert(datetime,'2021-12-31 13:15:00',120),290),
(5,convert(datetime,'2021-12-29 18:30:00',120),convert(datetime,'2021-12-29 19:15:00',120),290),
(5,convert(datetime,'2021-12-30 16:30:00',120),convert(datetime,'2021-12-30 17:35:00',120),290),
(6,convert(datetime,'2021-12-29 15:45:00',120),convert(datetime,'2021-12-29 16:35:00',120),290),
(6,convert(datetime,'2021-12-31 14:15:00',120),convert(datetime,'2021-12-31 15:30:00',120),290),
(7,convert(datetime,'2021-12-30 09:30:00',120),convert(datetime,'2021-12-30 10:35:00',120),290),
(7,convert(datetime,'2021-12-30 19:05:00',120),convert(datetime,'2021-12-30 20:25:00',120),290),
(1,convert(datetime,'2021-12-31 07:35:00',120),convert(datetime,'2021-12-31 08:45:00',120),290);
go