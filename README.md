# BulkGateHandler
BulkGate.Com SMS Sender Handler

    public class Example
    {
        public void Ex()
        {
            BulkGateSettings S = new BulkGateSettings
            {
                application_id = "27326",
                application_token = "palcmc7759cjnjcnvj",
                bulkgate_serviceURL = "https://portal.bulkgate.com/api/1.0/advanced/transactional",
                sender_id = "11325",
                sender_id_value = "TEST APP"
            };

            BulkGate B = new BulkGate(S);
            
            bool ok = false;

            var R = B.Send("905063333333", "hello test sms message",ref ok,Country.TURKEY);
            if(ok == true)
            {
                Console.WriteLine("send ok");
                Console.WriteLine(R);
            }
            else
            {
                Console.WriteLine($"send error : {R}");
            }
        }
    }
