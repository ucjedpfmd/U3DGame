namespace proto {
	public class p_role_pet_deploy : Message
	{
		public int max_num = 0;
		public object[] pet_deploys;
		public p_role_pet_deploy() {
		}
		public override string getClassName() {
			return "p_role_pet_deploy";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"max_num", "int", "null"},new string[] {"pet_deploys", "array", "p_pet_deploy"}};
		}
	}
}
