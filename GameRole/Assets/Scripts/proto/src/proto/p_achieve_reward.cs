namespace proto {
	public class p_achieve_reward : Message
	{
		public int gold_bind = 0;
		public int item_id = 0;
		public int formula = 0;
		public int title = 0;
		public p_achieve_reward() {
		}
		public override string getClassName() {
			return "p_achieve_reward";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"gold_bind", "int", "null"},new string[] {"item_id", "int", "null"},new string[] {"formula", "int", "null"},new string[] {"title", "int", "null"}};
		}
	}
}
