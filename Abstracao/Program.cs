using Abstracao;

ICarro carro = new CarroManual();
carro.TrocarMarcha();

ICarro carro1 = new CarroAutomatico();
carro1.TrocarMarcha();