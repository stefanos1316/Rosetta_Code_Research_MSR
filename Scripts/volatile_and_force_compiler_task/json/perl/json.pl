use JSON;

my $r = 1;

sub executeTask {
	my ($i) = @_;

	my $data = decode_json('{ "foo": 1, "bar": [10, "apples"] }');
	my $sample = { blue => [1,2], ocean => "water" };
	my $json_string = encode_json($sample);
	return ($i + 1);
}

for ( $a = 0; $a < 10000000; $a = $a + 1) {
	$r = executeTask($a + $r);
}
