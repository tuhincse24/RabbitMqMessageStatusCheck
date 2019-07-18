namespace RabbitMqMessageStatusCheck
{
    public class QueueInfo
    {
        public int memory { get; set; }
        public int messages { get; set; }
        public Messages_Details messages_details { get; set; }
        public int messages_ready { get; set; }
        public Messages_Ready_Details messages_ready_details { get; set; }
        public int messages_unacknowledged { get; set; }
        public Messages_Unacknowledged_Details messages_unacknowledged_details { get; set; }
        public string idle_since { get; set; }
        public string consumer_utilisation { get; set; }
        public string policy { get; set; }
        public string exclusive_consumer_tag { get; set; }
        public int consumers { get; set; }
        public Backing_Queue_Status backing_queue_status { get; set; }
        public string state { get; set; }
        public object[] incoming { get; set; }
        public object[] deliveries { get; set; }
        public object[] consumer_details { get; set; }
        public string name { get; set; }
        public string vhost { get; set; }
        public bool durable { get; set; }
        public bool auto_delete { get; set; }
        public Arguments arguments { get; set; }
        public string node { get; set; }
    }

    public class Messages_Details
    {
        public float rate { get; set; }
    }

    public class Messages_Ready_Details
    {
        public float rate { get; set; }
    }

    public class Messages_Unacknowledged_Details
    {
        public float rate { get; set; }
    }

    public class Backing_Queue_Status
    {
        public int q1 { get; set; }
        public int q2 { get; set; }
        public object[] delta { get; set; }
        public int q3 { get; set; }
        public int q4 { get; set; }
        public int len { get; set; }
        public int pending_acks { get; set; }
        public string target_ram_count { get; set; }
        public int ram_msg_count { get; set; }
        public int ram_ack_count { get; set; }
        public int next_seq_id { get; set; }
        public int persistent_count { get; set; }
        public float avg_ingress_rate { get; set; }
        public float avg_egress_rate { get; set; }
        public float avg_ack_ingress_rate { get; set; }
        public float avg_ack_egress_rate { get; set; }
    }

    public class Arguments
    {
    }

}
