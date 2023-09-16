namespace Car.Model
{
    class ParentClass
    {
        public string shadowMessage;
        public string overridMeessage;
        public string message;

        public ParentClass()
        {
            shadowMessage = "Hi";
            overridMeessage = "XXX";
        }

        public virtual string OverridMeessage
        {
            get { return overridMeessage; }
            set { overridMeessage = value; }
        }
        public virtual string Message
        {
            get { return message; }
            set { message = value; }
        }
    }

    class ChildOverwriteClass : ParentClass
    {
        public new string shadowMessage;

        public ChildOverwriteClass() : base()
        {
            message = "OOO";
        }

        public override string OverridMeessage
        {
            get { return "Hello from ChildClass"; } // 在子類別中重寫 Message 屬性的 getter
        }
    }
}
