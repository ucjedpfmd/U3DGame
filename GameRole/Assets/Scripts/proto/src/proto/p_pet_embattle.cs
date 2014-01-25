namespace proto {
	public class p_pet_embattle : Message
	{
		public double pet_id = 0;
		public int embattle_pos = 0;
		public int embattle_skill = 0;
		public p_pet_embattle() {
		}
		public override string getClassName() {
			return "p_pet_embattle";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"embattle_pos", "int", "null"},new string[] {"embattle_skill", "int", "null"}};
		}
	}
}
