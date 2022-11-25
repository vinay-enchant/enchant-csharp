namespace Enchant;

public static class Messenger
{
  public static string embedCode(string code) {
    return $@"
      <script>var enchant = enchant || []</script>
      <script src=""//platform.enchant.com"" data-enchant-messenger-id=""{code}"" async></script>
    ";
  }
}
