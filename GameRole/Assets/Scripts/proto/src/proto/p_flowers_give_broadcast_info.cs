namespace proto {
	public class p_flowers_give_broadcast_info : Message
	{
		public string giver = null;
		public string receiver = null;
		public int flowers_type = 0;
		public string broadcasting = null;
		public int special_effect = 0;
		public p_flowers_give_broadcast_info() {
		}
		public override string getClassName() {
			return "p_flowers_give_broadcast_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"giver", "string", "null"},new string[] {"receiver", "string", "null"},new string[] {"flowers_type", "int", "null"},new string[] {"broadcasting", "string", "null"},new string[] {"special_effect", "int", "null"}};
		}
	}
}
