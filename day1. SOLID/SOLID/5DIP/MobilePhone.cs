using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DIP
{
  // MobilePhone is a hight level module. MessageBuilder and MessageSender are the low level modules
  public class MobilePhone
  {
    public MobilePhone(MessageBuilder messageBuilder, MessageSender messageSender)
    {
      _messageBuilder = messageBuilder;
      _messageSender = messageSender;
    }

    private MessageBuilder _messageBuilder { get; set; }
    private MessageSender _messageSender { get; set; }

    public void SendMessage(string text)
    {
      Message message = _messageBuilder.BuildMessage(text);
      _messageSender.ConnectToTheNetwork();
      _messageSender.SendMessage(message);
    }
  }

  public class MessageBuilder
  {
    public Message BuildMessage(string text)
    {
      return new Message(text);
    }
  }

  public class Message
  {
    public Message(string text)
    {
      this.SetMessageId();
      this.SetMessageText(text);
    }
    public string MessageText { get; set; }
    public int MessageId { get; set; }

    private void SetMessageId()
    {
      var rnd = new Random();
      MessageId = rnd.Next(1, 99999);
    }

    private void SetMessageText(string text)
    {
      this.MessageText = text;
    }
  }

  public class MessageSender
  {
    public bool Connected = true;
    public void ConnectToTheNetwork()
    {
      if (Connected == false)
      {
        throw new Exception("Connection is broken!");
      }
    }
    public Message SendMessage(Message message)
    {
      // to something
      return message;
    }
  }
}
