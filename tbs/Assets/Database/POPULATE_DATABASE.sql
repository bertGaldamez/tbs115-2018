/*Insertando datos Iniciales de Opciones de Juego*/
INSERT INTO GAMEOPTIONS(PARAMETER,PVALUE) VALUES("GeneralVolume","1");

/*Insertando datos Iniciales de Nivel*/
INSERT INTO LEVELDATA(BESTSCORE,ACTUALSCORE,ROUNDTIME,POINTMULTIPLIER) VALUES(0,0,5,2);
INSERT INTO LEVELDATA(BESTSCORE,ACTUALSCORE,ROUNDTIME,POINTMULTIPLIER) VALUES(0,0,5,2);
INSERT INTO LEVELDATA(BESTSCORE,ACTUALSCORE,ROUNDTIME,POINTMULTIPLIER) VALUES(0,0,5,2);
INSERT INTO LEVELDATA(BESTSCORE,ACTUALSCORE,ROUNDTIME,POINTMULTIPLIER) VALUES(0,0,5,2);

/*Insertando datos Iniciales de Jugador*/
INSERT INTO PLAYERDATA(TOTALSCORE) VALUES(0);

/*Insertando datos Iniciales de Preguntas*/
INSERT INTO QUESTIONDATA(REALMNUMBER,QUESTION,ANSWER) VALUES(1,"¿Caminas sin hacer ruido cuando vas a tu cuarto?",'');
INSERT INTO QUESTIONDATA(REALMNUMBER,QUESTION,ANSWER) VALUES(1,"¿Compartes el baño de la casa con tu familia o visitas?",'');
INSERT INTO QUESTIONDATA(REALMNUMBER,QUESTION,ANSWER) VALUES(1,"¿Levantas tu mano para pedir turno en una conversación?",'');
INSERT INTO QUESTIONDATA(REALMNUMBER,QUESTION,ANSWER) VALUES(1,"¿Compartes tus pertenencias con otras personas si te lo piden?",'');
INSERT INTO QUESTIONDATA(REALMNUMBER,QUESTION,ANSWER) VALUES(1,"¿Sueles utilizar las palabras 'Por favor' y 'Gracias'?",'');
INSERT INTO QUESTIONDATA(REALMNUMBER,QUESTION,ANSWER) VALUES(1,"¿Si alguien te solicita algo, sueles ayudar?",'');
INSERT INTO QUESTIONDATA(REALMNUMBER,QUESTION,ANSWER) VALUES(1,"¿Si alguien cumple años, sueles felicitarlo?",'');
INSERT INTO QUESTIONDATA(REALMNUMBER,QUESTION,ANSWER) VALUES(1,"¿Si estas enojado, te alejas para tranquilizarte?",'');
INSERT INTO QUESTIONDATA(REALMNUMBER,QUESTION,ANSWER) VALUES(1,"¿Sueles saludar a tus amigos, aunque los veas todos los dias?",'');
INSERT INTO QUESTIONDATA(REALMNUMBER,QUESTION,ANSWER) VALUES(1,"¿Eres capaz de controlar el temor por los sonidos fuertes?",'');

COMMIT;