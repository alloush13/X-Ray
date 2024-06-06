using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;

using Telegram.Bot.Polling;
using Message = Telegram.Bot.Types.Message;
using Telegram.Bot.Exceptions;
namespace XRay
{
  
    internal class Telegram
    {

       public static TelegramBotClient  botClient = new TelegramBotClient("7303505807:AAEsf33nwbC2HfGIoF4D4UfSuuHPoQ1pc9E");
        public  async Task run()
        {
            var token = new CancellationTokenSource();
            var cancellationToken = token.Token;
            var receiverOptions = new ReceiverOptions { AllowedUpdates={ } };
            
            await botClient.ReceiveAsync(onMessage, errorMessage, receiverOptions, cancellationToken);

        }

       public async Task onMessage(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if(update.Message is Message message)
            {
                
                if (update.Message.Text == "/start")
                {
                    
                    await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Enter file name");
                }
                else
                {
                    if (FileOption.find("images\\", update.Message.Text, "jpeg").Length > 0)
                    {
                        await using Stream stream = System.IO.File.OpenRead(FileOption.subdirectoryPath + "images\\" + update.Message.Text + ".jpeg");
                        await botClient.SendPhotoAsync(update.Message.Chat.Id, InputFile.FromStream(stream));

                        if (FileOption.find("sounds\\", update.Message.Text, "wav").Length > 0)
                        {
                            await using Stream Soundstream = System.IO.File.OpenRead(FileOption.subdirectoryPath + "sounds\\" + update.Message.Text + ".wav");
                            await botClient.SendAudioAsync(update.Message.Chat.Id, InputFile.FromStream(Soundstream));
                        }
                        if (FileOption.find("", update.Message.Text, "zip").Length > 0)
                        {
                            await using Stream zipstream = System.IO.File.OpenRead(FileOption.subdirectoryPath + update.Message.Text + ".zip");
                            await botClient.SendDocumentAsync(update.Message.Chat.Id, InputFile.FromStream(zipstream), disableContentTypeDetection: true);
                        }
                    }
                    else
                    {
                        await botClient.SendTextMessageAsync(update.Message.Chat.Id, "File not found");
                    }
                    


                }
            }
        }
        public async Task errorMessage(ITelegramBotClient botClient, Exception e,CancellationToken cancellationToken)
        {
            if (e is ApiRequestException)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

       
       



    }
}

