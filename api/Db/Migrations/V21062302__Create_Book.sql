CREATE TABLE public.book
(
    id bigserial NOT NULL,
    name character varying NOT NULL,
    lauch_date date NOT NULL,
    price numeric NOT NULL,
    PRIMARY KEY (id)
);

ALTER TABLE public.book
    OWNER to postgres;