using GameInfantil.Models;

namespace GameInfantil.Utils
{
    public class Questions
    {
        public static List<QuizQuestion> GetQuestions()
        {
            var questions = new List<QuizQuestion>();

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "Por quê não podemos brincar com fogo?",
                Option1 = new QuizAnswer
                {
                    Text = "Ele pode nos congelar",
                    IsCorrect = false
                },
                Option2 = new QuizAnswer
                {
                    Text = "Ele pode nos queimar",
                    IsCorrect = true
                },
                Option3 = new QuizAnswer
                {
                    Text = "Ele irá ficar bravo comigo",
                    IsCorrect = false
                },
                Option4 = new QuizAnswer
                {
                    Text = "Ele irá morrer por causa disso",
                    IsCorrect = false
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "Como podemos nos prevenir do fogo?",
                Option1 = new QuizAnswer
                {
                    Text = "Ficar olhando até ele apagar",
                    IsCorrect = false
                },
                Option2 = new QuizAnswer
                {
                    Text = "Jogar folhas secas em cima do fogo",
                    IsCorrect = false
                },
                Option3 = new QuizAnswer
                {
                    Text = "Se jogar em cima do fogo para apagá-lo",
                    IsCorrect = false
                },
                Option4 = new QuizAnswer
                {
                    Text = "Ficando longe de lugares que utilizam fogo",
                    IsCorrect = true
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "Quando vejo uma situação de incêndio ou uma área com fogo, o quê devo fazer?",
                Option1 = new QuizAnswer
                {
                    Text = "Pedir ajuda para um adulto.",
                    IsCorrect = true
                },
                Option2 = new QuizAnswer
                {
                    Text = "Agir sozinho e tentar apagar o fogo",
                    IsCorrect = false
                },
                Option3 = new QuizAnswer
                {
                    Text = "Se aproximar mais para olhar o fogo",
                    IsCorrect = false
                },
                Option4 = new QuizAnswer
                {
                    Text = "Chamar meu animal de estimação",
                    IsCorrect = false
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "No fogão os cabos das panelas devem ser virados para dentro do fogão, \nporque esse ato deve ser obrigatorio em todas as casas?",
                Option1 = new QuizAnswer
                {
                    Text = "Porque a criança podera esbarrar nas panelas e pode \nocasionar um acidente.",
                    IsCorrect = true
                },
                Option2 = new QuizAnswer
                {
                    Text = "Porque as crianças podem pegar as panelas e brincar com elas.",
                    IsCorrect = false
                },
                Option3 = new QuizAnswer
                {
                    Text = "Porque o cachorro pode pegar a panela.",
                    IsCorrect = false
                },
                Option4 = new QuizAnswer
                {
                    Text = "Porque dessa maneira as panelas iram cozinhar melhor.",
                    IsCorrect = false
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "Se uma criança se queimar oque podemos passar em cima da queimadura?",
                Option1 = new QuizAnswer
                {
                    Text = "Pomadas..",
                    IsCorrect = false
                },
                Option2 = new QuizAnswer
                {
                    Text = "Manteiga.",
                    IsCorrect = false
                },
                Option3 = new QuizAnswer
                {
                    Text = "Gelo.",
                    IsCorrect = false
                },
                Option4 = new QuizAnswer
                {
                    Text = "Nenhuma das alternativas.",
                    IsCorrect = true
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "A torneira do gás deve estar aberta quando não estamos utilizando ele?",
                Option1 = new QuizAnswer
                {
                    Text = "Sim",
                    IsCorrect = false
                },
                Option2 = new QuizAnswer
                {
                    Text = "Não",
                    IsCorrect = true
                },

            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "As crianças devem ser orientadas durante as brincadeiras pois podem ter riscos. \r\nQual é a brincadeira?",
                Option1 = new QuizAnswer
                {
                    Text = "Esconde-esconde..",
                    IsCorrect = false
                },
                Option2 = new QuizAnswer
                {
                    Text = "Soltar pipas.",
                    IsCorrect = true
                },
                Option3 = new QuizAnswer
                {
                    Text = "Jogar futebol.",
                    IsCorrect = false
                },
                Option4 = new QuizAnswer
                {
                    Text = "Jogar Videogame.",
                    IsCorrect = false
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "A um produto que é muito perigoso para as crianças e deve ser super evitado \n em casa pelos pais, o nome dele é?",
                Option1 = new QuizAnswer
                {
                    Text = "Álcool em gel.",
                    IsCorrect = false
                },
                Option2 = new QuizAnswer
                {
                    Text = "Água.",
                    IsCorrect = false
                },
                Option3 = new QuizAnswer
                {
                    Text = "Materiais inflamáveis.",
                    IsCorrect = true
                },
                Option4 = new QuizAnswer
                {
                    Text = "Sucos.",
                    IsCorrect = false
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "Em uma casa tem varias tomadas tapadas para protegelas, porque isso é necessário?",
                Option1 = new QuizAnswer
                {
                    Text = "É para proteger as tomadas da poeira doméstica.",
                    IsCorrect = false
                },
                Option2 = new QuizAnswer
                {
                    Text = "É para evitar que uma criança enfie qualquer coisa dentro delas.",
                    IsCorrect = true
                },
                Option3 = new QuizAnswer
                {
                    Text = "Para proteger da água.",
                    IsCorrect = false
                },
                Option4 = new QuizAnswer
                {
                    Text = "Para deixar o ambiente mais bonito.",
                    IsCorrect = false
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "Quem são as principais vitimas de acidentes domésticos?",
                Option1 = new QuizAnswer
                {
                    Text = "Adultos.",
                    IsCorrect = false
                },
                Option2 = new QuizAnswer
                {
                    Text = "Crianças e animais.",
                    IsCorrect = false
                },
                Option3 = new QuizAnswer
                {
                    Text = "Adolescentes e adultos.",
                    IsCorrect = false
                },
                Option4 = new QuizAnswer
                {
                    Text = "Crianças e adolescentes.",
                    IsCorrect = true
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "Porque as crianças devem ficar longe da cozinha?",
                Option1 = new QuizAnswer
                {
                    Text = "Porque tem lugares melhores para elas estarem.",
                    IsCorrect = false
                },
                Option2 = new QuizAnswer
                {
                    Text = "Se não elas irão comer demais.",
                    IsCorrect = false
                },
                Option3 = new QuizAnswer
                {
                    Text = "Para evitar acidentes com fogo.",
                    IsCorrect = true
                },
                Option4 = new QuizAnswer
                {
                    Text = "Se não elas irão bagunçar a cozinha.",
                    IsCorrect = false
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "Caso a criança se queime, a queimadura irá criar bolhas, podemos estourar?",
                Option1 = new QuizAnswer
                {
                    Text = "Não",
                    IsCorrect = true
                },
                Option2 = new QuizAnswer
                {
                    Text = "Sim",
                    IsCorrect = false
                },

            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "Se alguém estiver pegando fogo o que essa pessoa tem que fazer?",
                Option1 = new QuizAnswer
                {
                    Text = "A vítima deve deitar no chão e rolar.",
                    IsCorrect = true
                },
                Option2 = new QuizAnswer
                {
                    Text = "Ficar parada.",
                    IsCorrect = false
                },
                Option3 = new QuizAnswer
                {
                    Text = "Se jogar em folhas.",
                    IsCorrect = false
                },
                Option4 = new QuizAnswer
                {
                    Text = "Se bater.",
                    IsCorrect = false
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "Em caso de acidente o que os pais devem fazer?",
                Option1 = new QuizAnswer
                {
                    Text = "Deixar a criança machucada.",
                    IsCorrect = false
                },
                Option2 = new QuizAnswer
                {
                    Text = "Lavar com água por 10 minutos e levar ao médico.",
                    IsCorrect = true
                },
                Option3 = new QuizAnswer
                {
                    Text = "Dar um sorvete para a criança.",
                    IsCorrect = false
                },
                Option4 = new QuizAnswer
                {
                    Text = "Mexer mais na ferida.",
                    IsCorrect = false
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "O quê irá acontecer se a criança passar receitas caseiras na queimadura?",
                Option1 = new QuizAnswer
                {
                    Text = "Irá ajudar a curar a ferida.",
                    IsCorrect = false
                },
                Option2 = new QuizAnswer
                {
                    Text = "Nada irá acontecer.",
                    IsCorrect = false
                },
                Option3 = new QuizAnswer
                {
                    Text = "Prejudicará mais a queimadura.",
                    IsCorrect = true
                },
                Option4 = new QuizAnswer
                {
                    Text = "A ferida irá trocar de cor.",
                    IsCorrect = false
                }
            });

            return questions;
        }
    }
}
