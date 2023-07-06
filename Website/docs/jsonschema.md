---
slug: /jsonschema
sidebar_position: 2
---

import CodeBlock from '@theme/CodeBlock';
import Schema from "@site/../JsonSchema/fido.schema.json";
import JSONSchemaViewer from "@theme/JSONSchemaViewer";

# JSON Schema

This schema was generated from the [C# model](./csharp) using [Json.NET Schema](https://www.newtonsoft.com/jsonschema).
JSON Schema has still [missing support descriptions for enum values](https://github.com/json-schema-org/json-schema-vocabularies/issues/47). Have a look at the [C# Model](./csharp) to find documentation about the meaning of the enum values.

<JSONSchemaViewer schema={ Schema } />

## Source

<CodeBlock language="json">{JSON.stringify(Schema, null, 2)}</CodeBlock>