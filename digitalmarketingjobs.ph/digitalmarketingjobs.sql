PGDMP     0                     y            digitalmarketingjobs    11.3    11.3 Z               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            �           1262    437639    digitalmarketingjobs    DATABASE     �   CREATE DATABASE digitalmarketingjobs WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_Singapore.1252' LC_CTYPE = 'English_Singapore.1252';
 $   DROP DATABASE digitalmarketingjobs;
             postgres    false            �            1259    437703    application    TABLE     /  CREATE TABLE public.application (
    application_id integer NOT NULL,
    client_id integer,
    candidate_id integer,
    date_applied date,
    resume_id integer,
    status_id integer,
    remarks text,
    date_updated date,
    job_id integer,
    cover_letter text,
    is_recommended boolean
);
    DROP TABLE public.application;
       public         postgres    false            �            1259    437701    application_application_id_seq    SEQUENCE     �   CREATE SEQUENCE public.application_application_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 5   DROP SEQUENCE public.application_application_id_seq;
       public       postgres    false    207            �           0    0    application_application_id_seq    SEQUENCE OWNED BY     a   ALTER SEQUENCE public.application_application_id_seq OWNED BY public.application.application_id;
            public       postgres    false    206            �            1259    437751    blog    TABLE     �   CREATE TABLE public.blog (
    blog_id integer NOT NULL,
    image_main bytea,
    image_thumb bytea,
    title text,
    content text,
    published_date date,
    views_count integer,
    is_featured boolean,
    date_created date
);
    DROP TABLE public.blog;
       public         postgres    false            �            1259    437749    blog_blog_id_seq    SEQUENCE     �   CREATE SEQUENCE public.blog_blog_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.blog_blog_id_seq;
       public       postgres    false    215            �           0    0    blog_blog_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.blog_blog_id_seq OWNED BY public.blog.blog_id;
            public       postgres    false    214            �            1259    437714 	   candidate    TABLE     A  CREATE TABLE public.candidate (
    candidate_id integer NOT NULL,
    name text,
    email text,
    password text,
    date_registered date,
    gcash_no integer,
    resume_content text,
    photo bytea,
    professional_title character varying(500),
    educations jsonb,
    experiences jsonb,
    video_url text
);
    DROP TABLE public.candidate;
       public         postgres    false            �            1259    437712    candidate_candidate_id_seq    SEQUENCE     �   CREATE SEQUENCE public.candidate_candidate_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.candidate_candidate_id_seq;
       public       postgres    false    209            �           0    0    candidate_candidate_id_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.candidate_candidate_id_seq OWNED BY public.candidate.candidate_id;
            public       postgres    false    208            �            1259    446182    candidate_jobs    TABLE     �   CREATE TABLE public.candidate_jobs (
    candidate_jobs_id integer NOT NULL,
    job_id integer,
    candidate_id integer,
    salary numeric,
    date_started date,
    date_ended date,
    is_active boolean
);
 "   DROP TABLE public.candidate_jobs;
       public         postgres    false            �            1259    446180 $   candidate_jobs_candidate_jobs_id_seq    SEQUENCE     �   CREATE SEQUENCE public.candidate_jobs_candidate_jobs_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ;   DROP SEQUENCE public.candidate_jobs_candidate_jobs_id_seq;
       public       postgres    false    217            �           0    0 $   candidate_jobs_candidate_jobs_id_seq    SEQUENCE OWNED BY     m   ALTER SEQUENCE public.candidate_jobs_candidate_jobs_id_seq OWNED BY public.candidate_jobs.candidate_jobs_id;
            public       postgres    false    216            �            1259    437692    client    TABLE     �   CREATE TABLE public.client (
    client_id integer NOT NULL,
    client_name text NOT NULL,
    email text NOT NULL,
    password text NOT NULL,
    contact_number text,
    company_name text,
    company_logo bytea,
    website text
);
    DROP TABLE public.client;
       public         postgres    false            �            1259    437690    client_client_id_seq    SEQUENCE     �   CREATE SEQUENCE public.client_client_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.client_client_id_seq;
       public       postgres    false    205            �           0    0    client_client_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.client_client_id_seq OWNED BY public.client.client_id;
            public       postgres    false    204            �            1259    437653    job    TABLE     �  CREATE TABLE public.job (
    job_id integer NOT NULL,
    job_type_id integer NOT NULL,
    title text NOT NULL,
    description text NOT NULL,
    date_posted date NOT NULL,
    date_expires date NOT NULL,
    is_filled boolean,
    client_id integer NOT NULL,
    salary_from integer,
    salary_to integer,
    tags text,
    job_role_id integer,
    is_spotlight boolean,
    filter_candidate boolean
);
    DROP TABLE public.job;
       public         postgres    false            �            1259    437736 	   job_alert    TABLE     �   CREATE TABLE public.job_alert (
    job_alert_id integer NOT NULL,
    date_created date,
    alert_name text,
    keywords text,
    status_id integer,
    frequency_id integer
);
    DROP TABLE public.job_alert;
       public         postgres    false            �            1259    437734    job_alert_job_alert_id_seq    SEQUENCE     �   CREATE SEQUENCE public.job_alert_job_alert_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.job_alert_job_alert_id_seq;
       public       postgres    false    213            �           0    0    job_alert_job_alert_id_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.job_alert_job_alert_id_seq OWNED BY public.job_alert.job_alert_id;
            public       postgres    false    212            �            1259    437651    job_job__id_seq    SEQUENCE     x   CREATE SEQUENCE public.job_job__id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.job_job__id_seq;
       public       postgres    false    199            �           0    0    job_job__id_seq    SEQUENCE OWNED BY     B   ALTER SEQUENCE public.job_job__id_seq OWNED BY public.job.job_id;
            public       postgres    false    198            �            1259    437681 	   job_level    TABLE     U   CREATE TABLE public.job_level (
    job_level_id integer NOT NULL,
    level text
);
    DROP TABLE public.job_level;
       public         postgres    false            �            1259    437679    job_level_job_level_id_seq    SEQUENCE     �   CREATE SEQUENCE public.job_level_job_level_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.job_level_job_level_id_seq;
       public       postgres    false    203            �           0    0    job_level_job_level_id_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.job_level_job_level_id_seq OWNED BY public.job_level.job_level_id;
            public       postgres    false    202            �            1259    437670    job_role    TABLE     R   CREATE TABLE public.job_role (
    job_role_id integer NOT NULL,
    role text
);
    DROP TABLE public.job_role;
       public         postgres    false            �            1259    437668    job_role_job_role_id_seq    SEQUENCE     �   CREATE SEQUENCE public.job_role_job_role_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.job_role_job_role_id_seq;
       public       postgres    false    201            �           0    0    job_role_job_role_id_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.job_role_job_role_id_seq OWNED BY public.job_role.job_role_id;
            public       postgres    false    200            �            1259    437642    job_type    TABLE     R   CREATE TABLE public.job_type (
    job_type_id integer NOT NULL,
    type text
);
    DROP TABLE public.job_type;
       public         postgres    false            �            1259    437640    job_type_job_type_id_seq    SEQUENCE     �   CREATE SEQUENCE public.job_type_job_type_id_seq
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.job_type_job_type_id_seq;
       public       postgres    false    197            �           0    0    job_type_job_type_id_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.job_type_job_type_id_seq OWNED BY public.job_type.job_type_id;
            public       postgres    false    196            �            1259    437725    resume    TABLE     �   CREATE TABLE public.resume (
    resume_id integer NOT NULL,
    title text,
    skills_summary text,
    skills_tags text,
    resume_upload bytea,
    date_added date
);
    DROP TABLE public.resume;
       public         postgres    false            �            1259    437723    resume_resume_id_seq    SEQUENCE     �   CREATE SEQUENCE public.resume_resume_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.resume_resume_id_seq;
       public       postgres    false    211            �           0    0    resume_resume_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.resume_resume_id_seq OWNED BY public.resume.resume_id;
            public       postgres    false    210            �
           2604    437706    application application_id    DEFAULT     �   ALTER TABLE ONLY public.application ALTER COLUMN application_id SET DEFAULT nextval('public.application_application_id_seq'::regclass);
 I   ALTER TABLE public.application ALTER COLUMN application_id DROP DEFAULT;
       public       postgres    false    206    207    207            �
           2604    437754    blog blog_id    DEFAULT     l   ALTER TABLE ONLY public.blog ALTER COLUMN blog_id SET DEFAULT nextval('public.blog_blog_id_seq'::regclass);
 ;   ALTER TABLE public.blog ALTER COLUMN blog_id DROP DEFAULT;
       public       postgres    false    214    215    215            �
           2604    437717    candidate candidate_id    DEFAULT     �   ALTER TABLE ONLY public.candidate ALTER COLUMN candidate_id SET DEFAULT nextval('public.candidate_candidate_id_seq'::regclass);
 E   ALTER TABLE public.candidate ALTER COLUMN candidate_id DROP DEFAULT;
       public       postgres    false    208    209    209            �
           2604    446185     candidate_jobs candidate_jobs_id    DEFAULT     �   ALTER TABLE ONLY public.candidate_jobs ALTER COLUMN candidate_jobs_id SET DEFAULT nextval('public.candidate_jobs_candidate_jobs_id_seq'::regclass);
 O   ALTER TABLE public.candidate_jobs ALTER COLUMN candidate_jobs_id DROP DEFAULT;
       public       postgres    false    216    217    217            �
           2604    437695    client client_id    DEFAULT     t   ALTER TABLE ONLY public.client ALTER COLUMN client_id SET DEFAULT nextval('public.client_client_id_seq'::regclass);
 ?   ALTER TABLE public.client ALTER COLUMN client_id DROP DEFAULT;
       public       postgres    false    204    205    205            �
           2604    446191 
   job job_id    DEFAULT     i   ALTER TABLE ONLY public.job ALTER COLUMN job_id SET DEFAULT nextval('public.job_job__id_seq'::regclass);
 9   ALTER TABLE public.job ALTER COLUMN job_id DROP DEFAULT;
       public       postgres    false    198    199    199            �
           2604    437739    job_alert job_alert_id    DEFAULT     �   ALTER TABLE ONLY public.job_alert ALTER COLUMN job_alert_id SET DEFAULT nextval('public.job_alert_job_alert_id_seq'::regclass);
 E   ALTER TABLE public.job_alert ALTER COLUMN job_alert_id DROP DEFAULT;
       public       postgres    false    213    212    213            �
           2604    437684    job_level job_level_id    DEFAULT     �   ALTER TABLE ONLY public.job_level ALTER COLUMN job_level_id SET DEFAULT nextval('public.job_level_job_level_id_seq'::regclass);
 E   ALTER TABLE public.job_level ALTER COLUMN job_level_id DROP DEFAULT;
       public       postgres    false    203    202    203            �
           2604    437673    job_role job_role_id    DEFAULT     |   ALTER TABLE ONLY public.job_role ALTER COLUMN job_role_id SET DEFAULT nextval('public.job_role_job_role_id_seq'::regclass);
 C   ALTER TABLE public.job_role ALTER COLUMN job_role_id DROP DEFAULT;
       public       postgres    false    201    200    201            �
           2604    446246    job_type job_type_id    DEFAULT     |   ALTER TABLE ONLY public.job_type ALTER COLUMN job_type_id SET DEFAULT nextval('public.job_type_job_type_id_seq'::regclass);
 C   ALTER TABLE public.job_type ALTER COLUMN job_type_id DROP DEFAULT;
       public       postgres    false    197    196    197            �
           2604    437728    resume resume_id    DEFAULT     t   ALTER TABLE ONLY public.resume ALTER COLUMN resume_id SET DEFAULT nextval('public.resume_resume_id_seq'::regclass);
 ?   ALTER TABLE public.resume ALTER COLUMN resume_id DROP DEFAULT;
       public       postgres    false    211    210    211            r          0    437703    application 
   TABLE DATA               �   COPY public.application (application_id, client_id, candidate_id, date_applied, resume_id, status_id, remarks, date_updated, job_id, cover_letter, is_recommended) FROM stdin;
    public       postgres    false    207   �j       z          0    437751    blog 
   TABLE DATA               �   COPY public.blog (blog_id, image_main, image_thumb, title, content, published_date, views_count, is_featured, date_created) FROM stdin;
    public       postgres    false    215   �j       t          0    437714 	   candidate 
   TABLE DATA               �   COPY public.candidate (candidate_id, name, email, password, date_registered, gcash_no, resume_content, photo, professional_title, educations, experiences, video_url) FROM stdin;
    public       postgres    false    209   �j       |          0    446182    candidate_jobs 
   TABLE DATA               ~   COPY public.candidate_jobs (candidate_jobs_id, job_id, candidate_id, salary, date_started, date_ended, is_active) FROM stdin;
    public       postgres    false    217   �j       p          0    437692    client 
   TABLE DATA               ~   COPY public.client (client_id, client_name, email, password, contact_number, company_name, company_logo, website) FROM stdin;
    public       postgres    false    205   k       j          0    437653    job 
   TABLE DATA               �   COPY public.job (job_id, job_type_id, title, description, date_posted, date_expires, is_filled, client_id, salary_from, salary_to, tags, job_role_id, is_spotlight, filter_candidate) FROM stdin;
    public       postgres    false    199   k       x          0    437736 	   job_alert 
   TABLE DATA               n   COPY public.job_alert (job_alert_id, date_created, alert_name, keywords, status_id, frequency_id) FROM stdin;
    public       postgres    false    213   ;k       n          0    437681 	   job_level 
   TABLE DATA               8   COPY public.job_level (job_level_id, level) FROM stdin;
    public       postgres    false    203   Xk       l          0    437670    job_role 
   TABLE DATA               5   COPY public.job_role (job_role_id, role) FROM stdin;
    public       postgres    false    201   uk       h          0    437642    job_type 
   TABLE DATA               5   COPY public.job_type (job_type_id, type) FROM stdin;
    public       postgres    false    197   �k       v          0    437725    resume 
   TABLE DATA               j   COPY public.resume (resume_id, title, skills_summary, skills_tags, resume_upload, date_added) FROM stdin;
    public       postgres    false    211   �k       �           0    0    application_application_id_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('public.application_application_id_seq', 1, false);
            public       postgres    false    206            �           0    0    blog_blog_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.blog_blog_id_seq', 1, false);
            public       postgres    false    214            �           0    0    candidate_candidate_id_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.candidate_candidate_id_seq', 1, false);
            public       postgres    false    208            �           0    0 $   candidate_jobs_candidate_jobs_id_seq    SEQUENCE SET     S   SELECT pg_catalog.setval('public.candidate_jobs_candidate_jobs_id_seq', 1, false);
            public       postgres    false    216            �           0    0    client_client_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.client_client_id_seq', 1, false);
            public       postgres    false    204            �           0    0    job_alert_job_alert_id_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.job_alert_job_alert_id_seq', 1, false);
            public       postgres    false    212            �           0    0    job_job__id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.job_job__id_seq', 1, false);
            public       postgres    false    198            �           0    0    job_level_job_level_id_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.job_level_job_level_id_seq', 1, false);
            public       postgres    false    202            �           0    0    job_role_job_role_id_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.job_role_job_role_id_seq', 1, false);
            public       postgres    false    200            �           0    0    job_type_job_type_id_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.job_type_job_type_id_seq', 1, false);
            public       postgres    false    196            �           0    0    resume_resume_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.resume_resume_id_seq', 1, false);
            public       postgres    false    210            �
           2606    437711    application application_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public.application
    ADD CONSTRAINT application_pkey PRIMARY KEY (application_id);
 F   ALTER TABLE ONLY public.application DROP CONSTRAINT application_pkey;
       public         postgres    false    207            �
           2606    437759    blog blog_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.blog
    ADD CONSTRAINT blog_pkey PRIMARY KEY (blog_id);
 8   ALTER TABLE ONLY public.blog DROP CONSTRAINT blog_pkey;
       public         postgres    false    215            �
           2606    446190 "   candidate_jobs candidate_jobs_pkey 
   CONSTRAINT     o   ALTER TABLE ONLY public.candidate_jobs
    ADD CONSTRAINT candidate_jobs_pkey PRIMARY KEY (candidate_jobs_id);
 L   ALTER TABLE ONLY public.candidate_jobs DROP CONSTRAINT candidate_jobs_pkey;
       public         postgres    false    217            �
           2606    437722    candidate candidate_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.candidate
    ADD CONSTRAINT candidate_pkey PRIMARY KEY (candidate_id);
 B   ALTER TABLE ONLY public.candidate DROP CONSTRAINT candidate_pkey;
       public         postgres    false    209            �
           2606    437700    client client_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.client
    ADD CONSTRAINT client_pkey PRIMARY KEY (client_id);
 <   ALTER TABLE ONLY public.client DROP CONSTRAINT client_pkey;
       public         postgres    false    205            �
           2606    437744    job_alert job_alert_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.job_alert
    ADD CONSTRAINT job_alert_pkey PRIMARY KEY (job_alert_id);
 B   ALTER TABLE ONLY public.job_alert DROP CONSTRAINT job_alert_pkey;
       public         postgres    false    213            �
           2606    437689    job_level job_level_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.job_level
    ADD CONSTRAINT job_level_pkey PRIMARY KEY (job_level_id);
 B   ALTER TABLE ONLY public.job_level DROP CONSTRAINT job_level_pkey;
       public         postgres    false    203            �
           2606    446193    job job_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.job
    ADD CONSTRAINT job_pkey PRIMARY KEY (job_id);
 6   ALTER TABLE ONLY public.job DROP CONSTRAINT job_pkey;
       public         postgres    false    199            �
           2606    437678    job_role job_role_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.job_role
    ADD CONSTRAINT job_role_pkey PRIMARY KEY (job_role_id);
 @   ALTER TABLE ONLY public.job_role DROP CONSTRAINT job_role_pkey;
       public         postgres    false    201            �
           2606    446248    job_type job_type_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.job_type
    ADD CONSTRAINT job_type_pkey PRIMARY KEY (job_type_id);
 @   ALTER TABLE ONLY public.job_type DROP CONSTRAINT job_type_pkey;
       public         postgres    false    197            �
           2606    437733    resume resume_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.resume
    ADD CONSTRAINT resume_pkey PRIMARY KEY (resume_id);
 <   ALTER TABLE ONLY public.resume DROP CONSTRAINT resume_pkey;
       public         postgres    false    211            �
           2606    446206 $   application application_candidate_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.application
    ADD CONSTRAINT application_candidate_fk FOREIGN KEY (candidate_id) REFERENCES public.candidate(candidate_id);
 N   ALTER TABLE ONLY public.application DROP CONSTRAINT application_candidate_fk;
       public       postgres    false    207    209    2780            �
           2606    446211 !   application application_client_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.application
    ADD CONSTRAINT application_client_fk FOREIGN KEY (client_id) REFERENCES public.client(client_id);
 K   ALTER TABLE ONLY public.application DROP CONSTRAINT application_client_fk;
       public       postgres    false    207    2776    205            �
           2606    446261    application application_job_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.application
    ADD CONSTRAINT application_job_fk FOREIGN KEY (job_id) REFERENCES public.job(job_id) ON DELETE CASCADE;
 H   ALTER TABLE ONLY public.application DROP CONSTRAINT application_job_fk;
       public       postgres    false    207    199    2770            �
           2606    446241 !   application application_resume_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.application
    ADD CONSTRAINT application_resume_fk FOREIGN KEY (resume_id) REFERENCES public.resume(resume_id);
 K   ALTER TABLE ONLY public.application DROP CONSTRAINT application_resume_fk;
       public       postgres    false    211    2782    207            �
           2606    446216     candidate_jobs candidate_jobs_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.candidate_jobs
    ADD CONSTRAINT candidate_jobs_fk FOREIGN KEY (candidate_id) REFERENCES public.candidate(candidate_id);
 J   ALTER TABLE ONLY public.candidate_jobs DROP CONSTRAINT candidate_jobs_fk;
       public       postgres    false    2780    217    209            �
           2606    446221 "   candidate_jobs candidate_jobs_fk_1    FK CONSTRAINT     �   ALTER TABLE ONLY public.candidate_jobs
    ADD CONSTRAINT candidate_jobs_fk_1 FOREIGN KEY (job_id) REFERENCES public.job(job_id);
 L   ALTER TABLE ONLY public.candidate_jobs DROP CONSTRAINT candidate_jobs_fk_1;
       public       postgres    false    217    199    2770            �
           2606    446236    job job_client_fk    FK CONSTRAINT     z   ALTER TABLE ONLY public.job
    ADD CONSTRAINT job_client_fk FOREIGN KEY (client_id) REFERENCES public.client(client_id);
 ;   ALTER TABLE ONLY public.job DROP CONSTRAINT job_client_fk;
       public       postgres    false    199    2776    205            �
           2606    446231    job job_jobrole_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.job
    ADD CONSTRAINT job_jobrole_fk FOREIGN KEY (job_role_id) REFERENCES public.job_role(job_role_id);
 <   ALTER TABLE ONLY public.job DROP CONSTRAINT job_jobrole_fk;
       public       postgres    false    2772    199    201            �
           2606    446249    job job_jobtype_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.job
    ADD CONSTRAINT job_jobtype_fk FOREIGN KEY (job_type_id) REFERENCES public.job_type(job_type_id);
 <   ALTER TABLE ONLY public.job DROP CONSTRAINT job_jobtype_fk;
       public       postgres    false    199    197    2768            r      x������ � �      z      x������ � �      t      x������ � �      |      x������ � �      p      x������ � �      j      x������ � �      x      x������ � �      n      x������ � �      l      x������ � �      h      x������ � �      v      x������ � �     