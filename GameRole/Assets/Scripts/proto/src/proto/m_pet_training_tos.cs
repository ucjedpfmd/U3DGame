namespace proto {
	public class m_pet_training_tos : Message
	{
		public int op_type = 0;
		public double pet_id = 0;
		public int training_time = 0;
		public bool bind_first = true;
		public bool auto_buy = true;
		public m_pet_training_tos() {
		}
		public override string getMethodName() {
			return "pet_training";
		}
		public override string getClassName() {
			return "m_pet_training_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"pet_id", "double", "null"},new string[] {"training_time", "int", "null"},new string[] {"bind_first", "bool", "null"},new string[] {"auto_buy", "bool", "null"}};
		}
	}
}
