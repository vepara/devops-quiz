create table IF NOT EXISTS public.logs
(
    id      integer generated always as identity,
    message text,
    constraint logs_pk primary key (id)
    );

create sequence IF NOT EXISTS public.logs_id_seq;

INSERT into logs (message) values ('{msg}');