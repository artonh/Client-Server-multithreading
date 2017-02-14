Objektivat e programimit te ketij projekti jane qe te behet dizajnimi, implementimi dhe testimi i programit klient dhe server qe te implementohet ne versionet TCP dhe UDP. Testimi perfshin testimin e TCP klientit dhe UDP klientit me serverin perkates. 
Protokolli FIEK eshte nje protokoll shume i thjeshte qe i lejon klientit dhe serverit t’i testoj lidhjet e tyre. Ky nuk eshte nje protokoll standard, eshte TCP versioni i cili quhet FIEK-TCP dhe UDP versioni i cili quhet FIEK-UDP.
Programi eshte i thjeshte, permbane info te nevojshme per shfrytezim sa me te lehte.

Si  punon  serveri 
Serveri e lexon kerkesen nga lidhja qe krijon me klientin nepermejt socket-it.
Serveri e shqyrton kerkesen dhe varesisht nga metoda krijhet nje pergjigjje e serverit. 
Serveri e dergon pergjigjjen ne socket per ta derguar drejt klientit. 

Si  punon  klienti
Klienti shkruan kerkesen: “cfaredo” ne Console dhe kerkesa e tij ne anen e klientit konvertohet ne bajta dhe nepermes soketit dergohet ne server, gjithashtu serveri bene konvertimin nga bajtat ne string pastaj e proceson kerkesen, kthen ne bajta dhe i kthen pergjigjen klientit i cili e shfaq ne ekran.
