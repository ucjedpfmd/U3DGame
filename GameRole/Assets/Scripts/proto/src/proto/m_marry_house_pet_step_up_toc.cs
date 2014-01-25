namespace proto {
	public class m_marry_house_pet_step_up_toc : Message
	{
		public int err_code = 0;
		public p_house_pet house_pet = null;
		public m_marry_house_pet_step_up_toc() {
		}
		public override string getMethodName() {
			return "marry_house_pet_step_up";
		}
		public override string getClassName() {
			return "m_marry_house_pet_step_up_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"house_pet", "p_house_pet", "null"}};
		}
	}
}
