namespace proto {
	public class p_pet_embattle_reward : Message
	{
		public int type_id = 0;
		public int num = 1;
		public p_pet_embattle_reward() {
		}
		public override string getClassName() {
			return "p_pet_embattle_reward";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"num", "int", "null"}};
		}
	}
}
