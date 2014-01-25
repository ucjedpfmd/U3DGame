namespace proto {
	public class p_pet_training : Message
	{
		public int end_time = 0;
		public int training_star = 0;
		public p_pet_training() {
		}
		public override string getClassName() {
			return "p_pet_training";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"end_time", "int", "null"},new string[] {"training_star", "int", "null"}};
		}
	}
}
