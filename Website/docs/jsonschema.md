---
slug: /jsonschema
sidebar_position: 2
---

import CodeBlock from '@theme/CodeBlock';
import Schema from "@site/../JsonSchema/fido.schema.json";
import JSONSchemaViewer from "@theme/JSONSchemaViewer";

# JSON Schema

<JSONSchemaViewer schema={ Schema } />

## Source

<CodeBlock language="json">{JSON.stringify(Schema, null, 2)}</CodeBlock>