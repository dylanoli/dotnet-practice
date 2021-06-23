CREATE TABLE public.person
(
    id bigint NOT NULL,
    name character varying NOT NULL,
    age integer NOT NULL,
    gender character varying NOT NULL,
    PRIMARY KEY (id)
);

ALTER TABLE public.person
    OWNER to postgres;