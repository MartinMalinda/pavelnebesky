{\rtf1\ansi\ansicpg1250\cocoartf2509
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\paperw11900\paperh16840\margl1440\margr1440\vieww10800\viewh8400\viewkind0
\pard\tx560\tx1120\tx1680\tx2240\tx2800\tx3360\tx3920\tx4480\tx5040\tx5600\tx6160\tx6720\pardirnatural\partightenfactor0

\f0\fs24 \cf0 CREATE TABLE tasks (taskId int NOT NULL AUTO_INCREMENT, task varchar(255) NOT NULL, status ENUM('todo', 'doing', 'review', 'done') DEFAULT 'todo', PRIMARY KEY (taskId));\
\
INSERT INTO tasks (task) VALUES ('install mySQL'), ('create todo database'), ('create tasks table'), ('add some tasks'), ('try out CRUD operations');\
\
\
}