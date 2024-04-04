

using System;
class desafio02 {
  static void Main() {
     while (true){
         
         int escolha;
    
      Console.WriteLine("Bem- vindo(a) à pagina de voluntários no Asilo de Nova York, parece que você deseja acessar o histórico de Gwen Stacey");
      Console.WriteLine("Escolha o que deseja consultar:");
      Console.WriteLine("1. Atividades concluídas na semana");
      Console.WriteLine("2.Atividades extras");
      Console.WriteLine("3. Advertências");
      Console.WriteLine("4. Perfil do voluntário");
     escolha = int.Parse(Console.ReadLine());
      
      switch(escolha == 1){
           
           case 1:
          
          
          Console.WriteLine("Atividades de Gwen Stacey - Semana 7:");
          Console.WriteLine ("Segunda - Fez a leitura de livros para senhora Dolores, limpou estante da biblioteca e levou senhor Simon para passear no parque");
          Console.WriteLine ("Terça - Auxiliou no aprendizado de leitura do senhor Brown, leitura para as senhoras do quarto 12 e distribuiu sorvetes para a ala principal");
          Console.WriteLine ("Quarta - Levou as senhoras do quarto 12 para fazer compras (passeio semanal)");
          Console.WriteLine("Quinta - Auxiliou nas atividades de reaprendizado de leitura do senhor Brown e senhora Smith");
          Console.WriteLine("Sexta - Ajudou em um almoço benificiente organizado pelo asilo");
          Console.WriteLine("Sábado - dia livre");
           Console.WriteLine("Domingo - dia livre");
           
           break;
      
      case 2: //(escolha ==2)
          
         
          Console.WriteLine("1- Passeio com os idosos no parque");
          Console.WriteLine("2- Limpeza na biblioteca");
          Console.WriteLine ("3- Trouxe agasalhos fora da campanha do ano");
          break;
      
      case 3: //(escolha == 3) 
         
         
          Console.WriteLine("Advertências mensais - Gwen Stacey");
          Console.WriteLine("Janeiro - vazio ");
          Console.WriteLine("Fevereiro - vazio");
          Console.WriteLine( "Março - ficou devendo 2 livros emprestados da nossa biblioteca");
          Console.WriteLine("Abril - não cumpriu horário corretamente");
          break;
      
      case 4: //(escolha == 4) 
           
        
       Console.WriteLine("Gwendolyn Maxine Stacy, 17 anos - Nova York");
       Console.WriteLine ("Voluntariada há 5 meses, asilo de Nova York");
      break;
      
     
    
       }
      
      
      }

    
  int escolhas2; 
  
 do {
  Console.WriteLine("Se deseja saber mais sobre o programa de voluntarios, acesse:");
  Console.WriteLine("1. Experiencia da voluntariada acessada");
  Console.WriteLine("2. Como posso ajudar?");
  
  if (escolhas2== 1){
      
      Console.WriteLine("Gwen Stacey - Relato: Olá! Meu nome é Gwendolyn Maxine Stacy e me voluntariei para o trabalho no asilo de NYC. Inicialmente era uma atividade que planejava ser em prol da incrementação do currículo para a faculdade, mas depois de alguns meses vejo que é uma experiência de aprendizado pessoal. Se você deseja atividades extras para faculdade e crescimento pessoal, o programa é ideal. :)");
      
  }
   else if (escolhas2 == 2) {
       
       Console.WriteLine("Se você deseja ajuda em nossa casa ligue para o numero 4402-8922 e faça sua ficha! Será um prazer.");
       
       }
       while (escolhas== 4);
 
   }
      
  
    }
          
}
