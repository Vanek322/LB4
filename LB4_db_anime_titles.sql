PGDMP      2                }            Filimon_db_anime_titiles    17.2    17.2 3    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            �           1262    41336    Filimon_db_anime_titiles    DATABASE     �   CREATE DATABASE "Filimon_db_anime_titiles" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
 *   DROP DATABASE "Filimon_db_anime_titiles";
                     postgres    false            �            1259    41365    anime_titles    TABLE       CREATE TABLE public.anime_titles (
    id integer NOT NULL,
    id_type smallint NOT NULL,
    original_name text NOT NULL,
    name text NOT NULL,
    count_series smallint NOT NULL,
    duration smallint NOT NULL,
    stidio text NOT NULL,
    poster text,
    description text
);
     DROP TABLE public.anime_titles;
       public         heap r       postgres    false            �            1259    41364    anime_title_id_seq    SEQUENCE     �   CREATE SEQUENCE public.anime_title_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.anime_title_id_seq;
       public               postgres    false    224            �           0    0    anime_title_id_seq    SEQUENCE OWNED BY     J   ALTER SEQUENCE public.anime_title_id_seq OWNED BY public.anime_titles.id;
          public               postgres    false    223            �            1259    41347    genres    TABLE     W   CREATE TABLE public.genres (
    id smallint NOT NULL,
    genre_name text NOT NULL
);
    DROP TABLE public.genres;
       public         heap r       postgres    false            �            1259    41346    genres_id_seq    SEQUENCE     �   CREATE SEQUENCE public.genres_id_seq
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.genres_id_seq;
       public               postgres    false    220            �           0    0    genres_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.genres_id_seq OWNED BY public.genres.id;
          public               postgres    false    219            �            1259    41356    statuses    TABLE     Z   CREATE TABLE public.statuses (
    id smallint NOT NULL,
    status_name text NOT NULL
);
    DROP TABLE public.statuses;
       public         heap r       postgres    false            �            1259    41355    statuses_id_seq    SEQUENCE     �   CREATE SEQUENCE public.statuses_id_seq
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.statuses_id_seq;
       public               postgres    false    222            �           0    0    statuses_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.statuses_id_seq OWNED BY public.statuses.id;
          public               postgres    false    221            �            1259    41379    titles_genres    TABLE     ~   CREATE TABLE public.titles_genres (
    id integer NOT NULL,
    id_genre smallint NOT NULL,
    id_anime integer NOT NULL
);
 !   DROP TABLE public.titles_genres;
       public         heap r       postgres    false            �            1259    41378    titles_genres_id_seq    SEQUENCE     �   CREATE SEQUENCE public.titles_genres_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.titles_genres_id_seq;
       public               postgres    false    226            �           0    0    titles_genres_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.titles_genres_id_seq OWNED BY public.titles_genres.id;
          public               postgres    false    225            �            1259    41396    titles_statuses    TABLE     �   CREATE TABLE public.titles_statuses (
    id integer NOT NULL,
    id_status smallint NOT NULL,
    id_anime integer NOT NULL,
    date_status date
);
 #   DROP TABLE public.titles_statuses;
       public         heap r       postgres    false            �            1259    41395    titles_statuses_id_seq    SEQUENCE     �   CREATE SEQUENCE public.titles_statuses_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.titles_statuses_id_seq;
       public               postgres    false    228            �           0    0    titles_statuses_id_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.titles_statuses_id_seq OWNED BY public.titles_statuses.id;
          public               postgres    false    227            �            1259    41338    types    TABLE     U   CREATE TABLE public.types (
    id smallint NOT NULL,
    type_name text NOT NULL
);
    DROP TABLE public.types;
       public         heap r       postgres    false            �            1259    41337    types_id_seq    SEQUENCE     �   CREATE SEQUENCE public.types_id_seq
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.types_id_seq;
       public               postgres    false    218            �           0    0    types_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.types_id_seq OWNED BY public.types.id;
          public               postgres    false    217            =           2604    41368    anime_titles id    DEFAULT     q   ALTER TABLE ONLY public.anime_titles ALTER COLUMN id SET DEFAULT nextval('public.anime_title_id_seq'::regclass);
 >   ALTER TABLE public.anime_titles ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    223    224    224            ;           2604    41350 	   genres id    DEFAULT     f   ALTER TABLE ONLY public.genres ALTER COLUMN id SET DEFAULT nextval('public.genres_id_seq'::regclass);
 8   ALTER TABLE public.genres ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    219    220    220            <           2604    41359    statuses id    DEFAULT     j   ALTER TABLE ONLY public.statuses ALTER COLUMN id SET DEFAULT nextval('public.statuses_id_seq'::regclass);
 :   ALTER TABLE public.statuses ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    222    221    222            >           2604    41382    titles_genres id    DEFAULT     t   ALTER TABLE ONLY public.titles_genres ALTER COLUMN id SET DEFAULT nextval('public.titles_genres_id_seq'::regclass);
 ?   ALTER TABLE public.titles_genres ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    226    225    226            ?           2604    41399    titles_statuses id    DEFAULT     x   ALTER TABLE ONLY public.titles_statuses ALTER COLUMN id SET DEFAULT nextval('public.titles_statuses_id_seq'::regclass);
 A   ALTER TABLE public.titles_statuses ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    228    227    228            :           2604    41341    types id    DEFAULT     d   ALTER TABLE ONLY public.types ALTER COLUMN id SET DEFAULT nextval('public.types_id_seq'::regclass);
 7   ALTER TABLE public.types ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    218    217    218            �          0    41365    anime_titles 
   TABLE DATA           }   COPY public.anime_titles (id, id_type, original_name, name, count_series, duration, stidio, poster, description) FROM stdin;
    public               postgres    false    224   z:       �          0    41347    genres 
   TABLE DATA           0   COPY public.genres (id, genre_name) FROM stdin;
    public               postgres    false    220   �:       �          0    41356    statuses 
   TABLE DATA           3   COPY public.statuses (id, status_name) FROM stdin;
    public               postgres    false    222   ?;       �          0    41379    titles_genres 
   TABLE DATA           ?   COPY public.titles_genres (id, id_genre, id_anime) FROM stdin;
    public               postgres    false    226   �;       �          0    41396    titles_statuses 
   TABLE DATA           O   COPY public.titles_statuses (id, id_status, id_anime, date_status) FROM stdin;
    public               postgres    false    228   �;       �          0    41338    types 
   TABLE DATA           .   COPY public.types (id, type_name) FROM stdin;
    public               postgres    false    218   �;       �           0    0    anime_title_id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.anime_title_id_seq', 1, false);
          public               postgres    false    223            �           0    0    genres_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.genres_id_seq', 28, true);
          public               postgres    false    219            �           0    0    statuses_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.statuses_id_seq', 10, true);
          public               postgres    false    221            �           0    0    titles_genres_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.titles_genres_id_seq', 1, false);
          public               postgres    false    225            �           0    0    titles_statuses_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.titles_statuses_id_seq', 1, false);
          public               postgres    false    227            �           0    0    types_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.types_id_seq', 24, true);
          public               postgres    false    217            G           2606    41372    anime_titles anime_title_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.anime_titles
    ADD CONSTRAINT anime_title_pkey PRIMARY KEY (id);
 G   ALTER TABLE ONLY public.anime_titles DROP CONSTRAINT anime_title_pkey;
       public                 postgres    false    224            C           2606    41354    genres genres_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.genres
    ADD CONSTRAINT genres_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.genres DROP CONSTRAINT genres_pkey;
       public                 postgres    false    220            E           2606    41363    statuses statuses_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.statuses
    ADD CONSTRAINT statuses_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.statuses DROP CONSTRAINT statuses_pkey;
       public                 postgres    false    222            I           2606    41384     titles_genres titles_genres_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.titles_genres
    ADD CONSTRAINT titles_genres_pkey PRIMARY KEY (id);
 J   ALTER TABLE ONLY public.titles_genres DROP CONSTRAINT titles_genres_pkey;
       public                 postgres    false    226            K           2606    41401 $   titles_statuses titles_statuses_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.titles_statuses
    ADD CONSTRAINT titles_statuses_pkey PRIMARY KEY (id);
 N   ALTER TABLE ONLY public.titles_statuses DROP CONSTRAINT titles_statuses_pkey;
       public                 postgres    false    228            A           2606    41345    types types_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.types
    ADD CONSTRAINT types_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.types DROP CONSTRAINT types_pkey;
       public                 postgres    false    218            M           2606    41390 .   titles_genres fk_titles_genres_to_anime_titles    FK CONSTRAINT     �   ALTER TABLE ONLY public.titles_genres
    ADD CONSTRAINT fk_titles_genres_to_anime_titles FOREIGN KEY (id_anime) REFERENCES public.anime_titles(id) ON UPDATE CASCADE ON DELETE CASCADE;
 X   ALTER TABLE ONLY public.titles_genres DROP CONSTRAINT fk_titles_genres_to_anime_titles;
       public               postgres    false    226    224    4679            N           2606    41385 (   titles_genres fk_titles_genres_to_genres    FK CONSTRAINT     �   ALTER TABLE ONLY public.titles_genres
    ADD CONSTRAINT fk_titles_genres_to_genres FOREIGN KEY (id_genre) REFERENCES public.genres(id) ON UPDATE CASCADE ON DELETE CASCADE;
 R   ALTER TABLE ONLY public.titles_genres DROP CONSTRAINT fk_titles_genres_to_genres;
       public               postgres    false    4675    226    220            O           2606    41407 2   titles_statuses fk_titles_statuses_to_anime_titles    FK CONSTRAINT     �   ALTER TABLE ONLY public.titles_statuses
    ADD CONSTRAINT fk_titles_statuses_to_anime_titles FOREIGN KEY (id_anime) REFERENCES public.anime_titles(id) ON UPDATE CASCADE ON DELETE CASCADE;
 \   ALTER TABLE ONLY public.titles_statuses DROP CONSTRAINT fk_titles_statuses_to_anime_titles;
       public               postgres    false    4679    228    224            P           2606    41402 .   titles_statuses fk_titles_statuses_to_statuses    FK CONSTRAINT     �   ALTER TABLE ONLY public.titles_statuses
    ADD CONSTRAINT fk_titles_statuses_to_statuses FOREIGN KEY (id_status) REFERENCES public.statuses(id) ON UPDATE CASCADE ON DELETE CASCADE;
 X   ALTER TABLE ONLY public.titles_statuses DROP CONSTRAINT fk_titles_statuses_to_statuses;
       public               postgres    false    228    4677    222            L           2606    41373    anime_titles fk_titles_to_types    FK CONSTRAINT     �   ALTER TABLE ONLY public.anime_titles
    ADD CONSTRAINT fk_titles_to_types FOREIGN KEY (id_type) REFERENCES public.types(id) ON UPDATE CASCADE ON DELETE CASCADE NOT VALID;
 I   ALTER TABLE ONLY public.anime_titles DROP CONSTRAINT fk_titles_to_types;
       public               postgres    false    218    224    4673            �      x������ � �      �   �   x�5�;�@Dk�0�]�w�0I(�@P@E�G��VH!��
�1��<�yc7�la^�ꦂ=UHZ�Lp@���j۪���T�w��Yq��[ak��>����%��%���u�]"��x�ϬP?\�?��	��tH�f,(��*u뼧��
v�      �   S   x�3�0����.��xa�� kӅ .s��.v_츰��0���Ѐ��B k���.6*\�T�
Գ���+F��� ��1�      �      x������ � �      �      x������ � �      �   �   x�m��	�PD�;U�1�i �HN)F�h^T��O �C~����4;�fG�nJ쥮J�rl2;��F�?��9A��7��+;�1���#����T�`�-�O_�9q^��{g'|���>8h7 ��PS�     