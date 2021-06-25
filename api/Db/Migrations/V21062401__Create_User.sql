CREATE TABLE public."user"
(
    id bigserial NOT NULL,
    login character varying NOT NULL,
    password character varying NOT NULL,
    refresh_token character varying NOT NULL,
    refresh_token_expiry_time time with time zone NOT NULL,
    PRIMARY KEY (id),
    CONSTRAINT u_login UNIQUE (login)
);

ALTER TABLE public."user"
    OWNER to postgres;