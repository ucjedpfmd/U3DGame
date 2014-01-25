namespace proto {
	public class p_pet_deploy : Message
	{
		public double pet_id = 0;
		public object[] deploy_props;
		public p_pet_deploy() {
		}
		public override string getClassName() {
			return "p_pet_deploy";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"deploy_props", "array", "p_add_prop"}};
		}
	}
}
